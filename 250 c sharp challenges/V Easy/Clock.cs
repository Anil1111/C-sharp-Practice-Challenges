



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################


using System;

public class Clock {
    private int hours, minutes;

    public Clock (int _hours, int _minutes) {
        hours = _hours;
        minutes = _minutes;
        while (minutes < 0) {
            minutes = 60 + minutes;
            hours--;
        }
        while (hours < 0)
            hours = 24 + hours;
        var h = minutes / 60;
        minutes = minutes - (h * 60);

        hours = (hours + h) % 24;
    }

    public Clock Add (int minutesToAdd) => new Clock (hours, minutes + minutesToAdd);

    public Clock Subtract (int minutesToSubtract) => new Clock (hours, minutes - minutesToSubtract);
    public override string ToString () => String.Format ("{0:00}:{1:00}", hours, minutes);
    public override bool Equals (object other) => (((Clock) other).minutes == this.minutes && ((Clock) other).hours == this.hours);
}
