using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        //Using Singleton Design Pattern
        private static MemberDAO instance = new();
        private static readonly object instanceLock = new();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new MemberDAO();
                }
                return instance;
            }
        }
        public List<Member> GetAll()
        {
            List<Member> listMember = [];
            try
            {
                using AppDbContext appDbContext = new();
                listMember = [.. appDbContext.Members];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listMember;
        }

        public Member? GetById(string id)
        {
            try
            {
                using AppDbContext appDbContext = new();
                var memberFound = appDbContext.Members.FirstOrDefault(u => u.MemberId.ToString() == id);
                if (memberFound != null)
                {
                    return memberFound;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Member member)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.Members.Add(member);
                appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                using AppDbContext appDbContext = new();
                appDbContext.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                appDbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Member member)
        {
            try
            {
                using AppDbContext appDbContext = new();

                //Delete Order of User
                var memberOrder = appDbContext.Orders.SingleOrDefault(m => m.Member.MemberId.ToString() == member.MemberId.ToString());
                if (memberOrder != null)
                {
                    appDbContext.Orders.Remove(memberOrder);
                }

                //Delete User
                appDbContext.Members.Remove(member);

                appDbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
