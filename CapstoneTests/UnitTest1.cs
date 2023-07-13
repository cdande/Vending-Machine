using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        Machine vendingMachine = new Machine();

        [TestMethod]
        public void InputValidity_ReturnTrue()
        {
            vendingMachine.LoadItemsFromFile();
            bool inputIsValid = vendingMachine.InputValidity("C4");
            Assert.IsTrue(inputIsValid);
        }
        [TestMethod]
        public void InputValidity_ReturnFalse()
        {
            vendingMachine.LoadItemsFromFile();
            bool inputIsValid = vendingMachine.InputValidity("Z109");
            Assert.IsFalse(inputIsValid);
        }
        //[TestMethod]
        //public void ItemNumberExists()
        //{
        //    vendingMachine.LoadItemsFromFile();
        //    int inputIsValid = vendingMachine.ItemNumber("");
        //    Assert.IsTrue(inputIsValid);
        //}
        [TestMethod]
        public void ItemAvailability_True()
        {
            vendingMachine.LoadItemsFromFile();
            Inventory item = vendingMachine.ItemInventory[0];

            bool inputIsValid = vendingMachine.Availability("A1", item);
            Assert.IsTrue(inputIsValid);
        }
        [TestMethod]
        public void ItemAvailability_False()
        {
            vendingMachine.LoadItemsFromFile();
            Inventory item = vendingMachine.ItemInventory[0];
            item.ItemQuantity = 0;
            bool inputIsValid = vendingMachine.Availability("A1", item);
            Assert.IsFalse(inputIsValid);
        }
    }
}
