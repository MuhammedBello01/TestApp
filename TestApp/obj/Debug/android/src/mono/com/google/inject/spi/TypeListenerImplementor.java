package mono.com.google.inject.spi;


public class TypeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.inject.spi.TypeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_hear:(Lcom/google/inject/TypeLiteral;Lcom/google/inject/spi/TypeEncounter;)V:GetHear_Lcom_google_inject_TypeLiteral_Lcom_google_inject_spi_TypeEncounter_Handler:Xamarin.Google.Inject.Spi.ITypeListenerInvoker, Xamarin.Google.Inject.Guice\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.Inject.Spi.ITypeListenerImplementor, Xamarin.Google.Inject.Guice", TypeListenerImplementor.class, __md_methods);
	}


	public TypeListenerImplementor ()
	{
		super ();
		if (getClass () == TypeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.Inject.Spi.ITypeListenerImplementor, Xamarin.Google.Inject.Guice", "", this, new java.lang.Object[] {  });
		}
	}


	public void hear (com.google.inject.TypeLiteral p0, com.google.inject.spi.TypeEncounter p1)
	{
		n_hear (p0, p1);
	}

	private native void n_hear (com.google.inject.TypeLiteral p0, com.google.inject.spi.TypeEncounter p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
