using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UICircularProgressRing;
using UIKit;

namespace UICircularProgressRing
{
    // @interface UICircularProgressRing : UIView
    [BaseType(typeof(UIView), Name = "_TtC22UICircularProgressRing22UICircularProgressRing")]
    interface UICircularProgressRing
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        UICircularProgressRingDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<UICircularProgressRingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL fullCircle;
        [Export("fullCircle")]
        bool FullCircle { get; set; }

        // @property (nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; set; }

        // @property (nonatomic) CGFloat minValue;
        [Export("minValue")]
        nfloat MinValue { get; set; }

        // @property (nonatomic) CGFloat maxValue;
        [Export("maxValue")]
        nfloat MaxValue { get; set; }

        // @property (nonatomic) enum UICircularProgressRingStyle ringStyle;
        [Export("ringStyle", ArgumentSemantic.Assign)]
        UICircularProgressRingStyle RingStyle { get; set; }

        // @property (nonatomic) BOOL showsValueKnob;
        [Export("showsValueKnob")]
        bool ShowsValueKnob { get; set; }

        // @property (nonatomic) CGFloat valueKnobSize;
        [Export("valueKnobSize")]
        nfloat ValueKnobSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueKnobColor;
        [Export("valueKnobColor", ArgumentSemantic.Strong)]
        UIColor ValueKnobColor { get; set; }

        // @property (nonatomic) CGFloat valueKnobShadowBlur;
        [Export("valueKnobShadowBlur")]
        nfloat ValueKnobShadowBlur { get; set; }

        // @property (nonatomic) CGSize valueKnobShadowOffset;
        [Export("valueKnobShadowOffset", ArgumentSemantic.Assign)]
        CGSize ValueKnobShadowOffset { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueKnobShadowColor;
        [Export("valueKnobShadowColor", ArgumentSemantic.Strong)]
        UIColor ValueKnobShadowColor { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull patternForDashes;
        [Export("patternForDashes", ArgumentSemantic.Copy)]
        NSNumber[] PatternForDashes { get; set; }

        // @property (nonatomic) CGFloat startAngle;
        [Export("startAngle")]
        nfloat StartAngle { get; set; }

        // @property (nonatomic) CGFloat endAngle;
        [Export("endAngle")]
        nfloat EndAngle { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull gradientColors;
        [Export("gradientColors", ArgumentSemantic.Copy)]
        UIColor[] GradientColors { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable gradientColorLocations;
        [NullAllowed, Export("gradientColorLocations", ArgumentSemantic.Copy)]
        NSNumber[] GradientColorLocations { get; set; }

        // @property (nonatomic) enum UICircularProgressRingGradientPosition gradientStartPosition;
        [Export("gradientStartPosition", ArgumentSemantic.Assign)]
        UICircularProgressRingGradientPosition GradientStartPosition { get; set; }

        // @property (nonatomic) enum UICircularProgressRingGradientPosition gradientEndPosition;
        [Export("gradientEndPosition", ArgumentSemantic.Assign)]
        UICircularProgressRingGradientPosition GradientEndPosition { get; set; }

        // @property (nonatomic) CGFloat outerRingWidth;
        [Export("outerRingWidth")]
        nfloat OuterRingWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull outerRingColor;
        [Export("outerRingColor", ArgumentSemantic.Strong)]
        UIColor OuterRingColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull outerBorderColor;
        [Export("outerBorderColor", ArgumentSemantic.Strong)]
        UIColor OuterBorderColor { get; set; }

        // @property (nonatomic) CGFloat outerBorderWidth;
        [Export("outerBorderWidth")]
        nfloat OuterBorderWidth { get; set; }

        // @property (nonatomic) CGLineCap outerCapStyle;
        [Export("outerCapStyle", ArgumentSemantic.Assign)]
        CGLineCap OuterCapStyle { get; set; }

        // @property (nonatomic) CGFloat innerRingWidth;
        [Export("innerRingWidth")]
        nfloat InnerRingWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull innerRingColor;
        [Export("innerRingColor", ArgumentSemantic.Strong)]
        UIColor InnerRingColor { get; set; }

        // @property (nonatomic) CGFloat innerRingSpacing;
        [Export("innerRingSpacing")]
        nfloat InnerRingSpacing { get; set; }

        // @property (nonatomic) CGLineCap innerCapStyle;
        [Export("innerCapStyle", ArgumentSemantic.Assign)]
        CGLineCap InnerCapStyle { get; set; }

        // @property (nonatomic) BOOL shouldShowValueText;
        [Export("shouldShowValueText")]
        bool ShouldShowValueText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fontColor;
        [Export("fontColor", ArgumentSemantic.Strong)]
        UIColor FontColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull valueIndicator;
        [Export("valueIndicator")]
        string ValueIndicator { get; set; }

        // @property (nonatomic) BOOL rightToLeft;
        [Export("rightToLeft")]
        bool RightToLeft { get; set; }

        // @property (nonatomic) BOOL showFloatingPoint;
        [Export("showFloatingPoint")]
        bool ShowFloatingPoint { get; set; }

        // @property (nonatomic) NSInteger decimalPlaces;
        [Export("decimalPlaces")]
        nint DecimalPlaces { get; set; }

        // @property (nonatomic) CAMediaTimingFunctionName _Nonnull animationTimingFunction;
        [Export("animationTimingFunction")]
        string AnimationTimingFunction { get; set; }

        // @property (readonly, nonatomic) BOOL isAnimating;
        [Export("isAnimating")]
        bool IsAnimating { get; }

        // @property (nonatomic) BOOL isClockwise;
        [Export("isClockwise")]
        bool IsClockwise { get; set; }

        // @property (readonly, nonatomic, class) Class _Nonnull layerClass;
        [Static]
        [Export("layerClass")]
        Class LayerClass { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(void)startProgressTo:(CGFloat)value duration:(NSTimeInterval)duration completion:(void (^ _Nullable)(void))completion;
        [Export("startProgressTo:duration:completion:")]
        void StartProgressTo(nfloat value, double duration, [NullAllowed] Action completion);

        // -(void)pauseProgress;
        [Export("pauseProgress")]
        void PauseProgress();

        // -(void)continueProgress;
        [Export("continueProgress")]
        void ContinueProgress();

        // -(void)resetProgress;
        [Export("resetProgress")]
        void ResetProgress();

        // -(void)animatePropertiesWithDuration:(NSTimeInterval)duration animations:(void (^ _Nonnull)(void))animations;
        [Export("animatePropertiesWithDuration:animations:")]
        void AnimatePropertiesWithDuration(double duration, Action animations);

        // -(void)animatePropertiesWithDuration:(NSTimeInterval)duration animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(void))completion;
        [Export("animatePropertiesWithDuration:animations:completion:")]
        void AnimatePropertiesWithDuration(double duration, Action animations, [NullAllowed] Action completion);
    }

    // @protocol UICircularProgressRingDelegate
    [BaseType(typeof(NSObject))]
    [Protocol(Name = "_TtP22UICircularProgressRing30UICircularProgressRingDelegate_"), Model]
    interface UICircularProgressRingDelegate
    {
        // @optional -(void)didFinishProgressFor:(UICircularProgressRing * _Nonnull)ring;
        [Export("didFinishProgressFor:")]
        void DidFinishProgressFor(UICircularProgressRing ring);

        // @optional -(void)didPauseProgressFor:(UICircularProgressRing * _Nonnull)ring;
        [Export("didPauseProgressFor:")]
        void DidPauseProgressFor(UICircularProgressRing ring);

        // @optional -(void)didContinueProgressFor:(UICircularProgressRing * _Nonnull)ring;
        [Export("didContinueProgressFor:")]
        void DidContinueProgressFor(UICircularProgressRing ring);

        // @optional -(void)didUpdateProgressValueFor:(UICircularProgressRing * _Nonnull)ring to:(CGFloat)newValue;
        [Export("didUpdateProgressValueFor:to:")]
        void DidUpdateProgressValueFor(UICircularProgressRing ring, nfloat newValue);

        // @optional -(void)willDisplayLabelFor:(UICircularProgressRing * _Nonnull)ring :(UILabel * _Nonnull)label;
        [Export("willDisplayLabelFor::")]
        void WillDisplayLabelFor(UICircularProgressRing ring, UILabel label);
    }

    // @interface UICircularProgressRingLayer : CAShapeLayer
    [BaseType(typeof(CAShapeLayer), Name = "_TtC22UICircularProgressRing27UICircularProgressRingLayer")]
    interface UICircularProgressRingLayer
    {
        // @property (nonatomic) BOOL fullCircle;
        [Export("fullCircle")]
        bool FullCircle { get; set; }

        // @property (nonatomic) CGFloat value;
        [Export("value")]
        nfloat Value { get; set; }

        // @property (nonatomic) CGFloat minValue;
        [Export("minValue")]
        nfloat MinValue { get; set; }

        // @property (nonatomic) CGFloat maxValue;
        [Export("maxValue")]
        nfloat MaxValue { get; set; }

        // @property (nonatomic) enum UICircularProgressRingStyle ringStyle;
        [Export("ringStyle", ArgumentSemantic.Assign)]
        UICircularProgressRingStyle RingStyle { get; set; }

        // @property (nonatomic) BOOL showsValueKnob;
        [Export("showsValueKnob")]
        bool ShowsValueKnob { get; set; }

        // @property (nonatomic) CGFloat valueKnobSize;
        [Export("valueKnobSize")]
        nfloat ValueKnobSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueKnobColor;
        [Export("valueKnobColor", ArgumentSemantic.Strong)]
        UIColor ValueKnobColor { get; set; }

        // @property (nonatomic) CGFloat valueKnobShadowBlur;
        [Export("valueKnobShadowBlur")]
        nfloat ValueKnobShadowBlur { get; set; }

        // @property (nonatomic) CGSize valueKnobShadowOffset;
        [Export("valueKnobShadowOffset", ArgumentSemantic.Assign)]
        CGSize ValueKnobShadowOffset { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull valueKnobShadowColor;
        [Export("valueKnobShadowColor", ArgumentSemantic.Strong)]
        UIColor ValueKnobShadowColor { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull patternForDashes;
        [Export("patternForDashes", ArgumentSemantic.Copy)]
        NSNumber[] PatternForDashes { get; set; }

        // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull gradientColors;
        [Export("gradientColors", ArgumentSemantic.Copy)]
        UIColor[] GradientColors { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable gradientColorLocations;
        [NullAllowed, Export("gradientColorLocations", ArgumentSemantic.Copy)]
        NSNumber[] GradientColorLocations { get; set; }

        // @property (nonatomic) enum UICircularProgressRingGradientPosition gradientStartPosition;
        [Export("gradientStartPosition", ArgumentSemantic.Assign)]
        UICircularProgressRingGradientPosition GradientStartPosition { get; set; }

        // @property (nonatomic) enum UICircularProgressRingGradientPosition gradientEndPosition;
        [Export("gradientEndPosition", ArgumentSemantic.Assign)]
        UICircularProgressRingGradientPosition GradientEndPosition { get; set; }

        // @property (nonatomic) CGFloat startAngle;
        [Export("startAngle")]
        nfloat StartAngle { get; set; }

        // @property (nonatomic) CGFloat endAngle;
        [Export("endAngle")]
        nfloat EndAngle { get; set; }

        // @property (nonatomic) CGFloat outerRingWidth;
        [Export("outerRingWidth")]
        nfloat OuterRingWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull outerRingColor;
        [Export("outerRingColor", ArgumentSemantic.Strong)]
        UIColor OuterRingColor { get; set; }

        // @property (nonatomic) CGLineCap outerCapStyle;
        [Export("outerCapStyle", ArgumentSemantic.Assign)]
        CGLineCap OuterCapStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull outerBorderColor;
        [Export("outerBorderColor", ArgumentSemantic.Strong)]
        UIColor OuterBorderColor { get; set; }

        // @property (nonatomic) CGFloat outerBorderWidth;
        [Export("outerBorderWidth")]
        nfloat OuterBorderWidth { get; set; }

        // @property (nonatomic) CGFloat innerRingWidth;
        [Export("innerRingWidth")]
        nfloat InnerRingWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull innerRingColor;
        [Export("innerRingColor", ArgumentSemantic.Strong)]
        UIColor InnerRingColor { get; set; }

        // @property (nonatomic) CGLineCap innerCapStyle;
        [Export("innerCapStyle", ArgumentSemantic.Assign)]
        CGLineCap InnerCapStyle { get; set; }

        // @property (nonatomic) CGFloat innerRingSpacing;
        [Export("innerRingSpacing")]
        nfloat InnerRingSpacing { get; set; }

        // @property (nonatomic) BOOL shouldShowValueText;
        [Export("shouldShowValueText")]
        bool ShouldShowValueText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fontColor;
        [Export("fontColor", ArgumentSemantic.Strong)]
        UIColor FontColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull valueIndicator;
        [Export("valueIndicator")]
        string ValueIndicator { get; set; }

        // @property (nonatomic) BOOL rightToLeft;
        [Export("rightToLeft")]
        bool RightToLeft { get; set; }

        // @property (nonatomic) BOOL showFloatingPoint;
        [Export("showFloatingPoint")]
        bool ShowFloatingPoint { get; set; }

        // @property (nonatomic) NSInteger decimalPlaces;
        [Export("decimalPlaces")]
        nint DecimalPlaces { get; set; }

        // @property (nonatomic) BOOL isClockwise;
        [Export("isClockwise")]
        bool IsClockwise { get; set; }

        [Wrap("WeakValueDelegate")]
        [NullAllowed]
        UICircularProgressRing ValueDelegate { get; set; }

        // @property (nonatomic, weak) UICircularProgressRing * _Nullable valueDelegate;
        [NullAllowed, Export("valueDelegate", ArgumentSemantic.Weak)]
        NSObject WeakValueDelegate { get; set; }

        //// -(void)drawInContext:(CGContextRef _Nonnull)ctx;
        //[Export("drawInContext:")]
        //unsafe void DrawInContext(CGContextRef* ctx);

        // +(BOOL)needsDisplayForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result));
        [Static]
        [Export("needsDisplayForKey:")]
        bool NeedsDisplayForKey(string key);

        // -(id<CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event __attribute__((warn_unused_result));
        [Export("actionForKey:")]
        [return: NullAllowed]
        CAAction ActionForKey(string @event);

        // -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
        [Export("initWithLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject layer);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }
}