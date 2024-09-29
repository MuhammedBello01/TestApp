; ModuleID = 'obj/Debug/android/marshal_methods.arm64-v8a.ll'
source_filename = "obj/Debug/android/marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [158 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 4
	i64 210515253464952879, ; 1: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 25
	i64 232391251801502327, ; 2: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 46
	i64 295915112840604065, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 47
	i64 634308326490598313, ; 4: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 38
	i64 702024105029695270, ; 5: System.Drawing.Common => 0x9be17343c0e7726 => 66
	i64 720058930071658100, ; 6: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 34
	i64 872800313462103108, ; 7: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 31
	i64 940822596282819491, ; 8: System.Transactions => 0xd0e792aa81923a3 => 69
	i64 1000557547492888992, ; 9: Mono.Security.dll => 0xde2b1c9cba651a0 => 78
	i64 1093530470802254671, ; 10: AccountNumberPredictionLibrary2.dll => 0xf2d002b5f3beb4f => 1
	i64 1120440138749646132, ; 11: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 56
	i64 1315114680217950157, ; 12: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 20
	i64 1425944114962822056, ; 13: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 73
	i64 1624659445732251991, ; 14: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 18
	i64 1628611045998245443, ; 15: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 40
	i64 1636321030536304333, ; 16: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 35
	i64 1743969030606105336, ; 17: System.Memory.dll => 0x1833d297e88f2af8 => 77
	i64 1795316252682057001, ; 18: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 19
	i64 1836611346387731153, ; 19: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 46
	i64 1875917498431009007, ; 20: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 17
	i64 1981742497975770890, ; 21: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 39
	i64 2136356949452311481, ; 22: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 43
	i64 2165725771938924357, ; 23: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 23
	i64 2262844636196693701, ; 24: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 31
	i64 2284400282711631002, ; 25: System.Web.Services => 0x1fb3d1f42fd4249a => 75
	i64 2329709569556905518, ; 26: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 37
	i64 2470498323731680442, ; 27: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 26
	i64 2479423007379663237, ; 28: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 50
	i64 2497223385847772520, ; 29: System.Runtime => 0x22a7eb7046413568 => 14
	i64 2547086958574651984, ; 30: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 16
	i64 2592350477072141967, ; 31: System.Xml.dll => 0x23f9e10627330e8f => 15
	i64 2624866290265602282, ; 32: mscorlib.dll => 0x246d65fbde2db8ea => 5
	i64 2923871038697555247, ; 33: Jsr305Binding => 0x2893ad37e69ec52f => 3
	i64 3017704767998173186, ; 34: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 56
	i64 3289520064315143713, ; 35: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 36
	i64 3311221304742556517, ; 36: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 13
	i64 3522470458906976663, ; 37: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 48
	i64 3531994851595924923, ; 38: System.Numerics => 0x31042a9aade235bb => 12
	i64 3571415421602489686, ; 39: System.Runtime.dll => 0x319037675df7e556 => 14
	i64 3716579019761409177, ; 40: netstandard.dll => 0x3393f0ed5c8c5c99 => 67
	i64 3727469159507183293, ; 41: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 45
	i64 3966267475168208030, ; 42: System.Memory => 0x370b03412596249e => 77
	i64 4056594422033399605, ; 43: PhoneNumbers.dll => 0x384beb225321bf35 => 7
	i64 4259099870907290018, ; 44: Xamarin.AopAlliance => 0x3b1b5cc4545751a2 => 54
	i64 4525561845656915374, ; 45: System.ServiceModel.Internals => 0x3ece06856b710dae => 74
	i64 4636684751163556186, ; 46: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 52
	i64 4782108999019072045, ; 47: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 22
	i64 4794310189461587505, ; 48: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 16
	i64 4795410492532947900, ; 49: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 48
	i64 5203618020066742981, ; 50: Xamarin.Essentials => 0x4836f704f0e652c5 => 55
	i64 5205316157927637098, ; 51: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 42
	i64 5376510917114486089, ; 52: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 50
	i64 5408338804355907810, ; 53: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 49
	i64 5507995362134886206, ; 54: System.Core.dll => 0x4c705499688c873e => 9
	i64 6319713645133255417, ; 55: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 38
	i64 6390701352697277701, ; 56: org.tensorflow.tensorflow-lite-api => 0x58b0550559212d05 => 6
	i64 6401687960814735282, ; 57: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 37
	i64 6504860066809920875, ; 58: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 23
	i64 6548213210057960872, ; 59: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 29
	i64 6589202984700901502, ; 60: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 57
	i64 6591024623626361694, ; 61: System.Web.Services.dll => 0x5b7805f9751a1b5e => 75
	i64 6659513131007730089, ; 62: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 34
	i64 6876862101832370452, ; 63: System.Xml.Linq => 0x5f6f85a57d108914 => 76
	i64 6894844156784520562, ; 64: System.Numerics.Vectors => 0x5faf683aead1ad72 => 13
	i64 7103753931438454322, ; 65: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 33
	i64 7488575175965059935, ; 66: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 76
	i64 7637365915383206639, ; 67: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 55
	i64 7654504624184590948, ; 68: System.Net.Http => 0x6a3a4366801b8264 => 65
	i64 7820441508502274321, ; 69: System.Data => 0x6c87ca1e14ff8111 => 68
	i64 7836164640616011524, ; 70: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 18
	i64 8044118961405839122, ; 71: System.ComponentModel.Composition => 0x6fa2739369944712 => 72
	i64 8083354569033831015, ; 72: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 36
	i64 8103644804370223335, ; 73: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 70
	i64 8167236081217502503, ; 74: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8402617192447357659, ; 75: PhoneNumbers => 0x749c17d14b6a32db => 7
	i64 8518412311883997971, ; 76: System.Collections.Immutable => 0x76377add7c28e313 => 8
	i64 8601935802264776013, ; 77: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 49
	i64 8626175481042262068, ; 78: Java.Interop => 0x77b654e585b55834 => 2
	i64 8684531736582871431, ; 79: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 71
	i64 9324707631942237306, ; 80: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 19
	i64 9662334977499516867, ; 81: System.Numerics.dll => 0x8617827802b0cfc3 => 12
	i64 9678050649315576968, ; 82: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 26
	i64 9740481398286460699, ; 83: Xamarin.TensorFlow.Lite => 0x872d2439762a271b => 64
	i64 9808709177481450983, ; 84: Mono.Android.dll => 0x881f890734e555e7 => 4
	i64 9834056768316610435, ; 85: System.Transactions.dll => 0x8879968718899783 => 69
	i64 9922564080815355521, ; 86: Xamarin.OW2.ASM.dll => 0x89b40775a20cb681 => 63
	i64 9998632235833408227, ; 87: Mono.Security => 0x8ac2470b209ebae3 => 78
	i64 10038780035334861115, ; 88: System.Net.Http.dll => 0x8b50e941206af13b => 65
	i64 10229024438826829339, ; 89: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 29
	i64 10430153318873392755, ; 90: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 27
	i64 10458115570434501856, ; 91: Xamarin.AopAlliance.dll => 0x9122b0b3abbaece0 => 54
	i64 10794144144066049118, ; 92: AccountNumberPredictionLibrary2 => 0x95cc80e8c16b745e => 1
	i64 10847732767863316357, ; 93: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 20
	i64 11023048688141570732, ; 94: System.Core => 0x98f9bc61168392ac => 9
	i64 11037814507248023548, ; 95: System.Xml => 0x992e31d0412bf7fc => 15
	i64 11071824625609515081, ; 96: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 57
	i64 11136029745144976707, ; 97: Jsr305Binding.dll => 0x9a8b200d4f8cd543 => 3
	i64 11162124722117608902, ; 98: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 53
	i64 11316027743246122076, ; 99: Xamarin.TensorFlow.Lite.dll => 0x9d0a9b4710a67c5c => 64
	i64 11340910727871153756, ; 100: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 28
	i64 11392833485892708388, ; 101: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 44
	i64 11529969570048099689, ; 102: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 53
	i64 11580057168383206117, ; 103: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 17
	i64 11597940890313164233, ; 104: netstandard => 0xa0f429ca8d1805c9 => 67
	i64 11672361001936329215, ; 105: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 33
	i64 12137774235383566651, ; 106: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 51
	i64 12269460666702402136, ; 107: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 8
	i64 12346958216201575315, ; 108: Xamarin.JavaX.Inject.dll => 0xab593514a5491b93 => 62
	i64 12451044538927396471, ; 109: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 32
	i64 12466513435562512481, ; 110: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 41
	i64 12487638416075308985, ; 111: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 30
	i64 12538491095302438457, ; 112: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 24
	i64 12550732019250633519, ; 113: System.IO.Compression => 0xae2d28465e8e1b2f => 11
	i64 12700543734426720211, ; 114: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 25
	i64 12892637769173325198, ; 115: Xamarin.OW2.ASM => 0xb2ebd9be315c558e => 63
	i64 12963446364377008305, ; 116: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 66
	i64 13169670654464853807, ; 117: TestApp => 0xb6c411af3043872f => 0
	i64 13370592475155966277, ; 118: System.Runtime.Serialization => 0xb98de304062ea945 => 73
	i64 13401370062847626945, ; 119: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 51
	i64 13402939433517888790, ; 120: Xamarin.Google.Guava.FailureAccess => 0xba00ce6728e8b516 => 59
	i64 13454009404024712428, ; 121: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 60
	i64 13491513212026656886, ; 122: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 21
	i64 13572454107664307259, ; 123: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 45
	i64 13647894001087880694, ; 124: System.Data.dll => 0xbd670f48cb071df6 => 68
	i64 13710828131551549296, ; 125: org.tensorflow.tensorflow-lite-api.dll => 0xbe46a58ae5901770 => 6
	i64 13865727802090930648, ; 126: Xamarin.Google.Guava.dll => 0xc06cf5f8e3e341d8 => 58
	i64 13889994164904059001, ; 127: Xamarin.Google.Inject.Guice.dll => 0xc0c32c19c35ae079 => 61
	i64 13959074834287824816, ; 128: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 32
	i64 13975254687929967048, ; 129: Xamarin.Google.Guava => 0xc1f2141837ada1c8 => 58
	i64 14124974489674258913, ; 130: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 24
	i64 14172845254133543601, ; 131: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 43
	i64 14261073672896646636, ; 132: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 44
	i64 14524915121004231475, ; 133: Xamarin.JavaX.Inject => 0xc992dd58a4283b33 => 62
	i64 14644440854989303794, ; 134: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 42
	i64 14792063746108907174, ; 135: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 60
	i64 14852515768018889994, ; 136: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 28
	i64 14955546685307135904, ; 137: Xamarin.Google.Inject.Guice => 0xcf8cc678ef80a7a0 => 61
	i64 14987728460634540364, ; 138: System.IO.Compression.dll => 0xcfff1ba06622494c => 11
	i64 14988210264188246988, ; 139: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 30
	i64 15370334346939861994, ; 140: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 27
	i64 15496469403750759496, ; 141: TestApp.dll => 0xd70e84d1a345fc48 => 0
	i64 15582737692548360875, ; 142: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 40
	i64 15609085926864131306, ; 143: System.dll => 0xd89e9cf3334914ea => 10
	i64 15777549416145007739, ; 144: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 47
	i64 16154507427712707110, ; 145: System => 0xe03056ea4e39aa26 => 10
	i64 16565028646146589191, ; 146: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 72
	i64 16579050217386591297, ; 147: Xamarin.Google.Guava.FailureAccess.dll => 0xe6149e5548b0c441 => 59
	i64 16822611501064131242, ; 148: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 70
	i64 16833383113903931215, ; 149: mscorlib => 0xe99c30c1484d7f4f => 5
	i64 17037200463775726619, ; 150: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 35
	i64 17544493274320527064, ; 151: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 22
	i64 17704177640604968747, ; 152: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 41
	i64 17710060891934109755, ; 153: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 39
	i64 17928294245072900555, ; 154: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 71
	i64 18116111925905154859, ; 155: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 21
	i64 18129453464017766560, ; 156: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 74
	i64 18380184030268848184 ; 157: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 52
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [158 x i32] [
	i32 4, i32 25, i32 46, i32 47, i32 38, i32 66, i32 34, i32 31, ; 0..7
	i32 69, i32 78, i32 1, i32 56, i32 20, i32 73, i32 18, i32 40, ; 8..15
	i32 35, i32 77, i32 19, i32 46, i32 17, i32 39, i32 43, i32 23, ; 16..23
	i32 31, i32 75, i32 37, i32 26, i32 50, i32 14, i32 16, i32 15, ; 24..31
	i32 5, i32 3, i32 56, i32 36, i32 13, i32 48, i32 12, i32 14, ; 32..39
	i32 67, i32 45, i32 77, i32 7, i32 54, i32 74, i32 52, i32 22, ; 40..47
	i32 16, i32 48, i32 55, i32 42, i32 50, i32 49, i32 9, i32 38, ; 48..55
	i32 6, i32 37, i32 23, i32 29, i32 57, i32 75, i32 34, i32 76, ; 56..63
	i32 13, i32 33, i32 76, i32 55, i32 65, i32 68, i32 18, i32 72, ; 64..71
	i32 36, i32 70, i32 2, i32 7, i32 8, i32 49, i32 2, i32 71, ; 72..79
	i32 19, i32 12, i32 26, i32 64, i32 4, i32 69, i32 63, i32 78, ; 80..87
	i32 65, i32 29, i32 27, i32 54, i32 1, i32 20, i32 9, i32 15, ; 88..95
	i32 57, i32 3, i32 53, i32 64, i32 28, i32 44, i32 53, i32 17, ; 96..103
	i32 67, i32 33, i32 51, i32 8, i32 62, i32 32, i32 41, i32 30, ; 104..111
	i32 24, i32 11, i32 25, i32 63, i32 66, i32 0, i32 73, i32 51, ; 112..119
	i32 59, i32 60, i32 21, i32 45, i32 68, i32 6, i32 58, i32 61, ; 120..127
	i32 32, i32 58, i32 24, i32 43, i32 44, i32 62, i32 42, i32 60, ; 128..135
	i32 28, i32 61, i32 11, i32 30, i32 27, i32 0, i32 40, i32 10, ; 136..143
	i32 47, i32 10, i32 72, i32 59, i32 70, i32 5, i32 35, i32 22, ; 144..151
	i32 41, i32 39, i32 71, i32 21, i32 74, i32 52 ; 152..157
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
