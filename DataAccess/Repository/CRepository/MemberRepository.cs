using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.CRepository
{
    public class MemberRepository : IMemberRepository
    {
        public void Create(Member member) => MemberDAO.Instance.Create(member);
        public void Delete(Member member) => MemberDAO.Instance.Delete(member);

        public List<Member> GetAll() => MemberDAO.Instance.GetAll();

        public Member? GetById(string id) => MemberDAO.Instance.GetById(id);

        public void Update(Member member) => MemberDAO.Instance.Update(member);
    }
}
