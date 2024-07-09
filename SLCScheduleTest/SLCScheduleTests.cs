using SLCSchedule;
using SLCSchedule.Models;

namespace SLCSchedule;

[TestClass]
public class SLCScheduleTests
{
    [TestMethod]
    public void isAvailableTest1()
    {
        // Arrange
        Employee test = new Employee("Test", "One", Employee.Position.Recreation);
        test.AddAvailability(8, 0, 10, 0);
        test.AddAvailability(12, 0, 14, 0);
        test.AddAvailability(16, 0, 20, 0);
        Shift shift = new Shift(new TimeRange(12, 0, 14, 0));

        // Act
        var actual = shift.isAvailable(test);

        // Assert
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void isNotAvailableTest1()
    {
        // Arrange
        Employee test = new Employee("Test", "Two", Employee.Position.Supervisor);
        test.AddAvailability(8, 0, 10, 0);
        test.AddAvailability(16, 0, 20, 0);
        Shift shift = new Shift(new TimeRange(12, 0, 14, 0));

        // Act
        var actual = shift.isAvailable(test);

        // Assert
        Assert.IsFalse(actual);
    }
}