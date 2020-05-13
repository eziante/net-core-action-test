using System;
using gce;
using NUnit.Framework;

namespace gce.test
{
  [TestFixture]
  public class WeatherForecastTest
  {
    [Test]
    public void ctor_test()
    {
      WeatherForecast wf = new WeatherForecast { Date = DateTime.Now.Date, Summary = "summary", TemperatureC = 23 };

      Assert.AreEqual(DateTime.Now.Date, wf.Date);
      Assert.AreEqual("summary", wf.Summary);
      Assert.AreEqual(23, wf.TemperatureC);
    }
  }
}
