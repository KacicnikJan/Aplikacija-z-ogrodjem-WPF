using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        bool vpis(string uporabniško_ime, string geslo);

        [OperationContract]
        List<Student> PridobiVseStudente();
        [OperationContract]
        List<Studentski_dom> PridobiVseDomove();
        [OperationContract]
        Student VrniStudenta(int emso);
        [OperationContract]
        Student IzpisNajstarejsega();
        [OperationContract]
        Studentski_dom VrniDom();
        [OperationContract]
        double IzpisPovprecneStarosti();
        [OperationContract]
        bool DodajStudenta(int id, int emso, string ime, string priimek, int letoRojstva);
        [OperationContract]
        bool DodajStudentskiDom(int stevilka_doma, string ime_doma, int leto_nastanka);
        [OperationContract]
        bool DodajStudentaVDomu(Student student, Studentski_dom studentski_dom, int dolzina_bivanja, string tip);
        [OperationContract]
        bool OdstraniStudenta(int id);
        [OperationContract]
        bool OdstraniDom(int id);
        [OperationContract]
        bool OdstraniStudentaizDomov(int id);
        [OperationContract]
        bool OdstraniDomIzStudentVDomu(int id);
        [OperationContract]
        bool UrediStudenta(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva);
        [OperationContract]
        bool UrediDom(int Id, string ime, int stevilkadoma);
        


        // TODO: Add your service operations here
    }




    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
