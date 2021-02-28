using System;


namespace asp_web
{
    public class weatherforecast
    {
        public DateTime date { get; set; }

        public int temperaturec { get; set; }

        public int temperaturef => 32 + (int)(temperaturec / 0.5556);

        public string summary { get; set; }
    }
}
