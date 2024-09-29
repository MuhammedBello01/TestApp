package mono.com.google.inject.spi;


public class InjectionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.inject.spi.InjectionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_afterInjection:(Ljava/lang/Object;)V:GetAfterInjection_Ljava_lang_Object_Handler:Xamarin.Google.Inject.Spi.IInjectionListenerInvoker, Xamarin.Google.Inject.Guice\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.Inject.Spi.IInjectionListenerImplementor, Xamarin.Google.Inject.Guice", InjectionListenerImplementor.class, __md_methods);
	}


	public InjectionListenerImplementor ()
	{
		super ();
		if (getClass () == InjectionListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.Inject.Spi.IInjectionListenerImplementor, Xamarin.Google.Inject.Guice", "", this, new java.lang.Object[] {  });
		}
	}


	public void afterInjection (java.lang.Object p0)
	{
		n_afterInjection (p0);
	}

	private native void n_afterInjection (java.lang.Object p0);

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
