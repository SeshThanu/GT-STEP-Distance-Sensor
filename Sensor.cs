#define trigPin 4
#define echoPin 5

long duration;
float distance;
int delta_t=10; //milliseconds

void setup() {
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  Serial.setTimeout(10);
  Serial.begin(9600);


}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(trigPin, LOW);
  delayMicroseconds(5);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH, 100000);
  distance = duration * 0.0343/2; // distance in cm 
  Serial.println(distance);
  delay(80);
}
