using DataAccessLayer;
using DataAccessLayer.Models;
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

        public PointBusiness()
        {
            
            this.pointRepository = new PointRepository();

            
        }

        public List<PreexeminationPoints> GetPointss()
        {
            return this.pointRepository.GetPoints();
        }

        public bool InsertPoints(PreexeminationPoints p)
        {
            if (this.pointRepository.InsertPoint(p) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePoints(PreexeminationPoints p)
        {
            if (this.pointRepository.UpdatePoint(p) > 0)
            {
                return true;
            }
            return false;
        }
       
        public bool DeletePoints1(PreexeminationPoints p, int idNew)
        {
            if (this.pointRepository.DeletePoint1(p, idNew) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
