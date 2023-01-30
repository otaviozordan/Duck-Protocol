byte frame[3];
byte myId = 0x10;
byte masterId = 0x0f;

//Prototipos:
void buscarPacote(byte* buffer, int nunBytes){
    byte storyByte;
    int adrr;
    for (int i = 0; i < nunBytes; i++) //Descarta lixo
    {
        storyByte = buffer[i];
        if (storyByte == 0x02)
        {
            for (int j = 0; j < 3; j++){
              adrr = i + j + 1;
              frame[j] = buffer[adrr];
              if (frame[j] == 0x03){
                break;
              }
            }
            break;
        }
    }
    executarFrame(frame[0], frame[1], frame[2]);
}

void enviarPayload(byte Idmst, byte endRet, byte dataRet){
  Serial.write(0x02);
  Serial.write(Idmst);
  Serial.write(endRet);
  Serial.write(dataRet);
  Serial.write(0x03);
}

void executarFrame(byte idRecv, byte endRecv, byte dataRecive){

  if (idRecv == 0x10)
  {
    switch (endRecv)
    {
      case 0xb0: //Escreve um valor digital baixo
        switch (dataRecive)
        {
          case 0x3d:
            digitalWrite(10, LOW);
            break;

          case 0x3c:
            digitalWrite(9, LOW);
            break;

          case 0x3b:
            digitalWrite(8, LOW);
            break;

          case 0x3a:
            digitalWrite(7, LOW);
            break;

          default:
          break;
        }
        break;

      case 0xb1:  //Escreve um valor digital alto
        switch (dataRecive) 
        {
          case 0x3d:
            digitalWrite(10, HIGH);
            break;

          case 0x3c:
            digitalWrite(9, HIGH);
            break;

          case 0x3b:
            digitalWrite(8, HIGH);
            break;

          case 0x3a:
            digitalWrite(7, HIGH);
            break;

          default:
          break;
        }
        break;

      case 0xb2: //Trata uma requisição de valor bolleano
        byte leitura = 0x30;
        switch (dataRecive)
        {
          case 0x39:
              if(digitalRead(5)){
                leitura = 0x31;
              }
              else{
                leitura = 0x30;
              }
              enviarPayload(masterId, 0xb3, leitura);
              break;

          case 0x38:
              if(digitalRead(4)){
                leitura = 0x31;
              }
              else{
                leitura = 0x30;
              }
              enviarPayload(masterId, 0xb3, leitura);
              break;

          case 0x37:
              if(digitalRead(3)){
                leitura = 0x31;
              }
              else{
                leitura = 0x30;
              }
              enviarPayload(masterId, 0xb3, leitura);
              break;

          case 0x36:
              if(digitalRead(2)){
                leitura = 0x31;
              }
              else{
                leitura = 0x30;
              }
              enviarPayload(masterId, 0xb3, leitura);
              break;

          default:
          break;
        }
        break;

      case 0xb4: //Recebe um valor bolleano
        break;

      default:
        break;
    }
  }
}

void setup()
{
  Serial.begin(9600);

  pinMode(10, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(7, OUTPUT);

  pinMode(5, INPUT);
  pinMode(4, INPUT);
  pinMode(3, INPUT);
  pinMode(2, INPUT);
}

void loop()
{
    if(Serial.available() > 4){
      int nunBytes = Serial.available();
      byte buffer [nunBytes];
      Serial.readBytes(buffer, nunBytes);
      buscarPacote(buffer, nunBytes);
    }
}
