public struct ApiSetup<T>
{
	public void SetupObjectA<T>() where T: ISomeinterfaceA
	{

	}
	public void SetupObjectB<T>() where T: ISomeinterfaceB
	{

	}
}
class Api
{
	public ApiSetup<T> For<T>(T obj)
	{
		return new ApiSetup<T>();
	}
}

interface ISomeinterfaceA{}
interface ISomeInterfaceB{}
public class ObjectA: ISomeinterfaceA{}
public class ObjectB: ISomeInterfaceB{}
class SomeClass
{
	public void Setup()
	{
		Api apiObject = new Api();

		apiObject.For(new ObjectA()).SetupObjectA();
		apiObject.For(new ObjectB()).SetupObjectB();
	}
}