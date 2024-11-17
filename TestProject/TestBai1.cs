using BaiTapOnl;

namespace TestProject
{
    public class TestBai1
    {
       private Bai1 _bai1 = new Bai1();
        private static IEnumerable<TestCaseData> List()
        {
            yield return new TestCaseData(
                new List<int> { 0, 4, 5, 6, 18, 10, 9, 21, 25, 40 },
                new List<int> { 0, 4, 6, 18, 10, 40 }
            );
        }
        [TestCaseSource(nameof(List))]
        public void TestKetqua(List<int> list,  List<int> Ketqua)
        {
            Assert.That(_bai1.CkeckSoChan(list), Is.EqualTo(Ketqua));
        }
    }
}