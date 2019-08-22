using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double UICircularProgressRingVersionNumber;
	[Field ("UICircularProgressRingVersionNumber", "__Internal")]
	double UICircularProgressRingVersionNumber { get; }

	// extern const unsigned char [] UICircularProgressRingVersionString;
	[Field ("UICircularProgressRingVersionString", "__Internal")]
	byte[] UICircularProgressRingVersionString { get; }

	// extern double UICircularProgressRingVersionNumber;
	[Field ("UICircularProgressRingVersionNumber", "__Internal")]
	double UICircularProgressRingVersionNumber { get; }

	// extern const unsigned char [] UICircularProgressRingVersionString;
	[Field ("UICircularProgressRingVersionString", "__Internal")]
	byte[] UICircularProgressRingVersionString { get; }
}

// @interface UICircularRing : UIView
[BaseType (typeof(UIView), Name = "_TtC22UICircularProgressRing14UICircularRing")]
interface UICircularRing
{
	// @property (nonatomic) BOOL fullCircle;
	[Export ("fullCircle")]
	bool FullCircle { get; set; }

	// @property (nonatomic) BOOL shouldShowValueText;
	[Export ("shouldShowValueText")]
	bool ShouldShowValueText { get; set; }

	// @property (nonatomic) CGFloat startAngle;
	[Export ("startAngle")]
	nfloat StartAngle { get; set; }

	// @property (nonatomic) CGFloat endAngle;
	[Export ("endAngle")]
	nfloat EndAngle { get; set; }

	// @property (nonatomic) CGFloat outerRingWidth;
	[Export ("outerRingWidth")]
	nfloat OuterRingWidth { get; set; }

	// @property (nonatomic, strong) UIColor * _Nonnull outerRingColor;
	[Export ("outerRingColor", ArgumentSemantic.Strong)]
	UIColor OuterRingColor { get; set; }

	// @property (nonatomic) CGFloat innerRingWidth;
	[Export ("innerRingWidth")]
	nfloat InnerRingWidth { get; set; }

	// @property (nonatomic, strong) UIColor * _Nonnull innerRingColor;
	[Export ("innerRingColor", ArgumentSemantic.Strong)]
	UIColor InnerRingColor { get; set; }

	// @property (nonatomic) CGFloat innerRingSpacing;
	[Export ("innerRingSpacing")]
	nfloat InnerRingSpacing { get; set; }

	// @property (nonatomic, strong) UIColor * _Nonnull fontColor;
	[Export ("fontColor", ArgumentSemantic.Strong)]
	UIColor FontColor { get; set; }

	// @property (nonatomic, strong) UIFont * _Nonnull font;
	[Export ("font", ArgumentSemantic.Strong)]
	UIFont Font { get; set; }

	// @property (nonatomic) BOOL isClockwise;
	[Export ("isClockwise")]
	bool IsClockwise { get; set; }

	// @property (readonly, nonatomic, class) Class _Nonnull layerClass;
	[Static]
	[Export ("layerClass")]
	Class LayerClass { get; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)drawRect:(CGRect)rect;
	[Export ("drawRect:")]
	void DrawRect (CGRect rect);
}

// @interface UICircularProgressRing : UICircularRing
[BaseType (typeof(UICircularRing), Name = "_TtC22UICircularProgressRing22UICircularProgressRing")]
interface UICircularProgressRing
{
	// @property (nonatomic) CGFloat value;
	[Export ("value")]
	nfloat Value { get; set; }

	// @property (nonatomic) CGFloat minValue;
	[Export ("minValue")]
	nfloat MinValue { get; set; }

	// @property (nonatomic) CGFloat maxValue;
	[Export ("maxValue")]
	nfloat MaxValue { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @interface UICircularTimerRing : UICircularRing
[BaseType (typeof(UICircularRing), Name = "_TtC22UICircularProgressRing19UICircularTimerRing")]
interface UICircularTimerRing
{
	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}
