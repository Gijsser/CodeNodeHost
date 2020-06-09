void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
Serial.println("{ \"sensNr\":1,\"instNr\":13,\"bRet\":20,\"data\":[48756080,2302038]}");
delay(1000);
}
