using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    public class POI
    {
        private string m_latitude, m_longitude;

        public POI()
        {
            m_latitude = "";
            m_longitude = "";
        }

        public POI(string latitude, string longitude)
        {
            m_latitude = latitude;
            m_longitude = longitude;
        }

        public void setLat(string lat) { m_latitude = lat; }
        public void setLong(string Long) { m_longitude = Long; }
        public string getLat() { return m_latitude; }
        public string getLong() { return m_longitude; }
    }
}
