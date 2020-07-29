using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class UserService
    {
        public SerializationService serialization;
        public string Directory;
        public string FileName;

        public UserService()
        {
            serialization = new SerializationService();

            Directory = "NewUser";
            FileName = "NewUser.dat";
        }
        public void CreateAccount(NewAccount item)
        {
            Repository.Instance.CreateAccounts.Add(item);
            serialization.Serialize(Repository.Instance.CreateAccounts, Directory, FileName);
        }
        public List<NewAccount> GetAll()

        {
            List<NewAccount> CreateAccount = (List<NewAccount>)serialization.Deserialize(Directory, FileName);

            if (CreateAccount != null)
            {
                Repository.Instance.CreateAccounts = CreateAccount;

            }
            return Repository.Instance.CreateAccounts;

        }
        public NewAccount GetByIndex(int index)
        {

            return Repository.Instance.CreateAccounts[index];
        }
    }
}
