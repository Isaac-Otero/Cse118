import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO_T= 18
GPIO_E = 24
GPIO.setup(GPIO_T, GPIO.OUT)
GPIO.setup(GPIO_E, GPIO.IN)
def distance():
    GPIO.output(GPIO_TRIGGER, True)
    time.sleep(0.00001)
    GPIO.output(GPIO_TRIGGER, False)
    StartTime = time.time()
    StopTime = time.time()
    while GPIO.input(GPIO_ECHO) == 0:
        StartTime = time.time()
    while GPIO.input(GPIO_ECHO) == 1:
        StopTime = time.time()
    TimeElapsed = StopTime - StartTime
    distance = (TimeElapsed * 33700) / 2
 
    return distance
 
if _name_== '__main__':
    try:
        while True:
            dist = distance()
            print ("Distance is = %.1f cm " % dist)
            time.sleep(1)
