using LinkedList;

namespace TestProject;

public class SinglyLinkedListTests
{
    [Test]
    public void Print_Empty_EmptyString()
    {
        // arrange
        var emptyList = new SinglyLinkedList<int>();
        var expectedResult = "";

        // act
        var actualResult = emptyList.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Print_NotEmpty_ElementsSeparateSpaces()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(5);
        list.AddFirst(2);
        var expectedResult = "2 5 ";

        // act
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
