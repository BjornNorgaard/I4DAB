using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handin
{
    public interface ISensorAccess
    {
        bool AddData(int sensorId, int apartmentId, double value, string timestamp);
    }
}
