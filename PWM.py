import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(18, GPIO.OUT)
led = GPIO.PWM(18, 500)
led.start(0)

while(1):
        for x in range(0, 101, 1):
                led.ChangeDutyCycle(50)
                time.sleep(0.1)
