using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub02
{
    internal class TV : Internet, Computer //하나는 상속 하나는 인터페이스로 많이 하긴함
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }
        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
    }
}
