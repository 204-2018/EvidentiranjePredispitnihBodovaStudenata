using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PointBusiness
    {

        public readonly PointRepository pointRepository;

        public StudentBusiness()
        {
            
            this.pointRepository = new PointRepository();

            
        }

        public List<PreexeminationPoint> GetPoints()
        {
            return this.pointRepository.GetPoint();
        }

        public bool InsertPoint(PreexeminationPoint p)
        {
            if (this.pointRepository.Insert(p) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePoint(PreexeminationPoint p)
        {
            if (this.pointRepository.Update(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeletePoint(PreexeminationPoint p)
        {
            if (this.pointRepository.Delete(p) > 0)
            {
                return true;
            }
            return false;
        }
       
        public bool DeletePoint1(Point p, int idNew)
        {
            if (this.pointtRepository.Delete1(p, idNew) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
