namespace b17.specs
{
    using NUnit.Framework;

    public static class Extensions
    {
        public static void ShouldEqual(this string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldEqual(this int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}