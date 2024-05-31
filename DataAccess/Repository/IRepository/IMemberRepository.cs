using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IMemberRepository
    {
        public List<Member> GetAll();
        public Member? GetById(string id);
        public void Create(Member? member);
        public void Update(Member? member);
        public void Delete(Member? member);
    }
}
