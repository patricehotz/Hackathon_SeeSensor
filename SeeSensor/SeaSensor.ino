#include <HTTPClient.h>


#include <WiFi.h>
#include <WebServer.h>
#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BME280.h>
#include <Arduino_JSON.h>

#define SEALEVELPRESSURE_HPA (1013.25)

Adafruit_BME280 bme;


float temperature, humidity, pressure, altitude;

//Geben Sie hier Ihre WLAN ssid und passwort ein
const char* hostAddres= "http://192.168.122.80/data";
const char* ssid = "Hackathon 2022";  
const char* password = "!Neuhack2022!";  
const char* macAdress = "00-1D-60-4A-8C-CB";


WebServer server(80);             
 
void setup() 
{
  Serial.begin(115200);
  delay(100);
  
  bme.begin(0x76);   

  Serial.println("Verbinden mit ");
  Serial.println(ssid);

  //Verbindung herstellen
  WiFi.begin(ssid, password);

  //WIFI prüfen 
  while (WiFi.status() != WL_CONNECTED) {
  delay(1000);
  Serial.print(".");
}

 
  Serial.println("");
  Serial.println("WiFi verbunden..!");
  Serial.print("IP= ");  Serial.println(WiFi.localIP());


  server.on("/", OnConnect);                 
  server.onNotFound(NotFound);

  server.begin();
  Serial.println("Start");
  

}

//////////////////////////// Hauptprogramm 

void loop() {
  server.handleClient();
    WiFiClient client;
  HTTPClient http;



  temperature = bme.readTemperature();
  humidity = bme.readHumidity();
  pressure = bme.readPressure() / 100.0F;
  altitude = bme.readAltitude(SEALEVELPRESSURE_HPA);
  server.send(200, "text/html", SendHTML(temperature,humidity,pressure,altitude)); 
  
  http.begin(client,hostAddres);
  http.addHeader("Content-Type","application/json");


  String body = "{\"macaddress\": \"" +  (String)macAdress + "\",\"light\": 0,\"airtemperature\": " +  (String)temperature + ",\"airhumidity\": " +  (String)humidity + ",\"airpressure\": " +  (String)pressure + ",\"watertemperature\":0,\"coordinatex\":0 ,\"coordinatey\":0}";

   Serial.println(body);

 int httpResponseCode = http.POST(body);
  Serial.println(httpResponseCode);

  delay(30000);
}

void OnConnect() {
 


  temperature = bme.readTemperature();
  humidity = bme.readHumidity();
  pressure = bme.readPressure() / 100.0F;
  altitude = bme.readAltitude(SEALEVELPRESSURE_HPA);
  server.send(200, "text/html", SendHTML(temperature,humidity,pressure,altitude)); 
  


}

void NotFound(){
  server.send(404, "text/plain", "Not found");
}


//////////////////////////// HTML Benutzeroberfläche 

String SendHTML(float temperature,float humidity,float pressure,float altitude)    //Send temperature , humidity , pressure und altitude 
{
  
  String str = "<!DOCTYPE html> <html>\n";
  str +="<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, user-scalable=no\">\n";
  str +="<meta http-equiv=\"refresh\" content=\"2\">\n"; //Automatische Seitenaktualisierung
  str +="<title>ESP32 Wetterstation</title>\n";
  str +="<style>html { font-family: Helvetica; display: inline-block; margin: 0px auto; text-align: center;}\n";
  str +="h1 {color: #0000FF;}\n"; //
  str +="body{margin-top: 50px;} h1 {color: #0000FF;margin: 50px auto 30px;}\n";
  str +="p {font-size: 24px;color: #444444;margin-bottom: 10px;}\n";
  str +="</style>\n";
  str +="</head>\n";
  str +="<body>\n";
  str +="<div id=\"webpage\">\n";
  str +="<h1>BME280 Wetterstation</h1>\n";
  str +="<p>Temperature: ";
  str +=temperature;
  str +="C</p>";
  str +="<p>Humidity: ";
  str +=humidity;
  str +="%</p>";
  str +="<p>Pressure: ";
  str +=pressure;
  str +="hPa</p>";
  str +="<p>Altitude: ";
  str +=altitude;
  str +="m</p>";  
  str +="</div>\n";
  str +="</body>\n";
  str +="</html>\n";
  
  return str;
}
