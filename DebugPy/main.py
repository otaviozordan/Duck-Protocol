import serial
import time
import random

adrId = 0x11
master = 0x0f

ser = serial.Serial()
ser.baudrate = 9600
ser.port = 'COM1'
ser.writeTimeout = 0

frame = [0xff, 0xff, 0xff]
leitura = True
count = 0

print("\nDebug iniciado, porta: " + str(ser.port))
print("\nSlave: " + hex(adrId))
if (input("Alterar(a) Continuar(c):\n") == 'a'):
    ser.port = input("Digite a porta serial: ")
try:
    ser.open()
    if (ser.isOpen()):
        print("Porta " + str(ser.port) + " aberta\n")
    else:
        print("Porta " + str(ser.port) + " fechada\n")
except:
    print("Erro ao abrir porta " + str(ser.port) + "\n")

time.sleep(1)
print("Aguardando pacotes...\n")

def interpretar(frame):
    global leitura
    if frame[0] == adrId:
        if frame[1] == 0xb0: #Escreve um valor digital baixo
            print("Desligando data: ", hex(frame[2]), end="\n")

        elif frame[1] == 0xb1: #Escreve um valor digital alto
            print("Ligando data: ", hex(frame[2]), end="\n")

        elif frame[1] == 0xb2:  #Requisita um valor bolleano
            print("Master está requisitando valor para data:", hex(frame[2]))
            leitura = random.choice([True, False])
            if leitura == True:
                print("Enviando nivel logico 1")
                enviarPayload(master, 0xb3, 0x31) #Devolve uma requisição bolleana
            else:
                print("Enviando nivel logico 0")
                enviarPayload(master, 0xb3, 0x30) #Devolve uma requisição bolleana

        elif frame[1] == 0xb4: #Trasfere um valor bolleano
            print("Master está trasferindo um valor")
            if frame[2] == 0x30:
                print("Recebendo nivel logico 0")
            elif frame[2] == 0x31:
                print("Recebendo nivel logico 1")
            else:
                print("Data invalida")
    else:
        print("Este não é meu id")

    global count
    count = count + 1
    print("----------------------------------",count,"----------------------------------")


def enviarPayload(master, end, data):
    payload = bytearray([0x02, master, end, data, 0x03])
    ser.write(payload)
    print("Payload enviado:", hex(0x02), hex(master), hex(end), hex(data), hex(0x03), "\n")

while True:
    #Busca numero de bytes no buffer
    nunBuffer = ser.inWaiting()

    if(nunBuffer > 4):
        buffer = [] #Limpa a lista

        #Le dados disponiveis
        buffer = ser.read(nunBuffer)
        print("-------------------------------------------------------------------------")
        print("\nBuffer completo: ",  end="")
        for i in range(len(buffer)):
            print(hex(buffer[i]),  end=" ")
        print("--> Com ", len(buffer) ," caracteres\n")

        #Para todos os bytes do buffer verficia se é igual a 0x02
        for i in range(len(buffer)):
            if buffer[0] == 0x02:
                buffer = buffer[1:] #Remove o 0x02
                print("Incio de quadro recebido: ", end=" ")
                for i in range(len(buffer)):
                    print(hex(buffer[i]),  end=" ")
                print("--> Resta: ", len(buffer), "bytes no buffer", end="\n");
                break #Ao encontrar cessa 
            buffer = buffer[1:]

        for i in range(3):
            frame[i] = buffer[i]
            print ("Recebido: ", hex(frame[i]), end="\n")

            #Verifica se recebeu endframe
            if (frame[i] == 0x03):
                print ("Endframe recebido na posição ", i + 1, " do frame", end="\n")

        if len(frame) != 3:
            print(" ".join(hex(ord(n)) for n in frame), "-> Frame corrompido", end="\n")

        if buffer[3] != 0x03:
            print("End frame não recebido\n")

        if buffer[3] == 0x03:
            print("End frame 0x03 recebido\n")

        if buffer[3] == 0x03 & len(frame) == 3:
            interpretar(frame)