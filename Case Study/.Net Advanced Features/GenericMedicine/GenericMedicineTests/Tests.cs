using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;
namespace GenericMedicineTests
{
    [TestFixture]
    public class Tests
    {
        Program p;

        [OneTimeSetUp]
        public void SetUp()
        {
            p = new Program(); 
        }

        [Test]
        [TestCase("Dolo 650", " Micromol F Tablet", "Paracetamol","2022/01/02",100.00)]
        [TestCase("Montair LC", "Rhinomax", "Levocetirizine", "2023/01/02", 140.00)]
        [TestCase("Remilyn D", "Remylin", ": Alpha lipoic acid","2024/10.12",80.00)]
        public void Medicine_ObjectCreation_Test(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            Medicine medicine = p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip);
            Assert.AreEqual(typeof(Medicine),medicine.GetType());
            Assert.AreEqual(name, medicine.Name);
        }


        [Test]
        [TestCase("Dolo 650", "", "Paracetamol", "2022 /01/02", 100.00)]
        [TestCase("Montair LC", "", "Levocetirizine", "2023/01/02", 140.00)]
        [TestCase("Remilyn D", null, ": Alpha lipoic acid", "2024/10.12", 80.00)]
        public void Medicine_EmptyGenericMedicineName_Exception(string name,string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Generic Medicine name cannot be empty. Please provide valid value"));
            
        }


        [Test]
        [TestCase("Dolo 650", "Micromol F Tablet", "Paracetamol", "2022/01/02", 0)]
        [TestCase("Montair LC", "Rhinomax", "Levocetirizine", "2023/01/02",null)]
        [TestCase("Remilyn D", "Remylin", ": Alpha lipoic acid", "2024/10.12", -100.00)]
        public void Medicine_PriceLessThanZero_Exception(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }


        [Test]
        [TestCase("Dolo 650", "Micromol F Tablet", "Paracetamol", "2020/01/02", 100.00)]
        [TestCase("Montair LC", "Rhinomax", "Levocetirizine", "2019/01/02", 140.00)]
        [TestCase("Remilyn D", "Remylin", ": Alpha lipoic acid", "2015/10.12", 80.00)]
        public void Medicine_DateLessThanCurrentDate_Exception(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }



        [Test]
        [TestCase(10,"2022/10/01","Chennai")]
        [TestCase(20, "2021/5/01", "Bangalore")]
        [TestCase(40, "2021/10/01", "Hyderabad")]
        public void Carton_ObjectCreation_Test(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Dolo 650", " Micromol F Tablet", "Paracetamol", DateTime.Parse("2022/12/01"), 100.00);
            CartonDetail carton = p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.AreEqual(typeof(CartonDetail), carton.GetType());
        }



        [Test]
        [TestCase(0, "2022/10/01", "Chennai")]
        [TestCase(-5, "2021/10/01", "Bangalore")]
        [TestCase(null, "2021/10/01", "Hyderabad")]
        public void Carton_StripCountLessThanZero_Exception(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Dolo 650", " Micromol F Tablet", "Paracetamol", DateTime.Parse("2022/01/01"), 100.00);
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }



        [Test]
        [TestCase(10, "2020/10/01", "Chennai")]
        [TestCase(20, "2021/01/01", "Bangalore")]
        [TestCase(40, "2020/07/01", "Hyderabad")]
        public void Carton_DateLessThanCurrentDate_Exception(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Dolo 650", " Micromol F Tablet", "Paracetamol", DateTime.Parse("2022/01/01"), 100.00);
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }



        [Test]
        [TestCase(10, "2022/10/01", "Chennai")]
        [TestCase(20, "2024/10/01", "Bangalore")]
        [TestCase(40, "2025/10/01", "Hyderabad")]
        public void Carton_MedicineObjectNull_Test(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = null;
            CartonDetail d= p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.AreEqual(null,d);
        }

   
    }
}
