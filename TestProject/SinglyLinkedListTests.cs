using LinkedList;

namespace TestProject;

public class SinglyLinkedListTests
{
    [Test]
    public void Print_Empty_EmptyString()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "";

        // act
        var actualResult = list.Print();

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

    [Test]
    public void AddFirst_ToEmptyList_AddsElementToHead()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "10 ";

        // act
        list.AddFirst(10);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddFirst_MultipleElements_AddsAtTheBeginning()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        var expectedResult = "30 20 10 ";

        // act
        list.AddFirst(30);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddLast_ToEmptyList_AddsElementAsHead()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "10 ";

        // act
        list.AddLast(10);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddLast_MultipleElements_AddsAtTheEnd()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        var expectedResult = "10 20 30 ";

        // act
        list.AddLast(30);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddFirstAndAddLast_Combined_MaintainsCorrectOrder()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(20);
        var expectedResult = "10 20 30 ";

        // act
        list.AddFirst(10);
        list.AddLast(30);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddRangeFirst_ToEmptyList_AddsElementInOriginalOrder()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var collection = new List<int> { 1, 2, 3 };
        var expectedResult = "1 2 3 ";

        // act
        list.AddRangeFirst(collection);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddRangeFirst_ToNotEmptyList_AddsElementToTheBeginning()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        var collection = new List<int> { 1, 2, 3 };
        var expectedResult = "1 2 3 10 ";

        // act
        list.AddRangeFirst(collection);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddRangeLast_ToEmptyList_AddsElementInOriginalOrder()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var collection = new List<int> { 4, 5, 6 };
        var expectedResult = "4 5 6 ";

        // act
        list.AddRangeLast(collection);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddRangeLast_ToNotEmptyList_AddsElementToTheEnd()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(3);
        var collection = new List<int> { 4, 5, 6 };
        var expectedResult = "3 4 5 6 ";

        // act
        list.AddRangeLast(collection);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void AddRangeMetods_EmptyCollections_DoesNotChangeList()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(5);
        var collection = new List<int>();
        var expectedResult = "5 ";

        // act
        list.AddRangeFirst(collection);
        list.AddRangeLast(collection);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveFirst_EmptyList_DoesNotThrowAndDoesNothing()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "";

        // act
        list.RemoveFirst();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveFirst_SingleElements_LeavesListEmpty()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        var expectedResult = " ";

        // act
        list.RemoveFirst();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveFirst_MultipleElements_RemoveOnlyFirstElement()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "20 10 ";

        // act
        list.RemoveFirst();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveLast_EmptyList_DoesNotThrowAndDoesNothing()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "";

        // act
        list.RemoveLast();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveLast_SingleElements_LeavesListEmpty()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        var expectedResult = " ";

        // act
        list.RemoveLast();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void RemoveLast_MultipleElements_RemoveOnlyLastElement()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "30 20 ";

        // act
        list.RemoveLast();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Remove_EmptyList_DoesNotThrowAndDoesNothing()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = " ";

        // act
        list.Remove(5);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Remove_SingleElements_LeavesListEmpty()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        var expectedResult = " ";

        // act
        list.Remove(10);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Remove_HeadElement_RemoveFirstElementCorrecly()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "20 10 ";

        // act
        list.Remove(30);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Remove_MiddleElement_RemoveTargetElementCorrecly()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "30 10 ";

        // act
        list.Remove(20);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Remove_EndElement_RemoveLastElementCorrecly()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "30 20 ";

        // act
        list.Remove(10);
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Clear_EmptyList_EmptyString()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        var expectedResult = "";

        // act
        list.Clear();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Clear_NotEmptyList_EmptyString()
    {
        // arrange
        var list = new SinglyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);
        var expectedResult = "";

        // act
        list.Clear();
        var actualResult = list.Print();

        // assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
