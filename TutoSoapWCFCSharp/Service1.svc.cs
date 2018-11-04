using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TutoSoapWCFCSharp.Entities;

namespace TutoSoapWCFCSharp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Race GetRaceExample()
        {
        
            Animal a01 = new Animal() { AnimalId = 1, Name = "Rantanplan" };
            Animal a02 = new Animal() { AnimalId = 2, Name = "Lassy" };
            Animal a03 = new Animal() { AnimalId = 3, Name = "Medor" };
            Animal a04 = new Animal() { AnimalId = 4, Name = "Milou" };
            Animal a05 = new Animal() { AnimalId = 5, Name = "Dartagnan" };

            ICollection<Animal> Animals = new HashSet<Animal>();
            Animals.Add(a01);
            Animals.Add(a02);
            Animals.Add(a03);
            Animals.Add(a04);
            Animals.Add(a05);

            Race race = new Race() { RaceId = 1, Name = "Chien", Animals = Animals };

            return race;

        }
    }
}
