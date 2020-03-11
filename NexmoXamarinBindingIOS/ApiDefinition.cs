﻿using System;
using Foundation;
//using NexmoClient;
using ObjCRuntime;

namespace NexmoXamarinIOS
{
	[Static]
	partial interface Constants
	{
		// extern double NexmoClientVersionNumber;
		[Field("NexmoClientVersionNumber", "__Internal")]
		double NexmoClientVersionNumber { get; }

		// extern const unsigned char [] NexmoClientVersionString;
		[Field("NexmoClientVersionString", "__Internal")]
		IntPtr NexmoClientVersionString { get; }

		// extern NSString *const _Nonnull NXMErrorDomain;
		[Field("NXMErrorDomain", "__Internal")]
		NSString NXMErrorDomain { get; }
	}

	// @interface NXMUser : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMUser
	{
		// @property (copy, nonatomic) NSString * _Nonnull uuid;
		[Export("uuid")]
		string Uuid { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull displayName;
		[Export("displayName")]
		string DisplayName { get; set; }
	}

	// @protocol NXMClientDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface NXMClientDelegate
	{
		// @required -(void)client:(NXMClient * _Nonnull)client didChangeConnectionStatus:(NXMConnectionStatus)status reason:(NXMConnectionStatusReason)reason;
		[Abstract]
		[Export("client:didChangeConnectionStatus:reason:")]
		void DidChangeConnectionStatus(NXMClient client, NXMConnectionStatus status, NXMConnectionStatusReason reason);

		// @required -(void)client:(NXMClient * _Nonnull)client didReceiveError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("client:didReceiveError:")]
		void DidReceiveError(NXMClient client, NSError error);

		// @optional -(void)client:(NXMClient * _Nonnull)client didReceiveCall:(NXMCall * _Nonnull)call;
		[Export("client:didReceiveCall:")]
		void DidReceiveCall(NXMClient client, NXMCall call);

		// @optional -(void)client:(NXMClient * _Nonnull)client didReceiveConversation:(NXMConversation * _Nonnull)conversation;
		[Export("client:didReceiveConversation:")]
		void DidReceiveConversation(NXMClient client, NXMConversation conversation);
	}

	// @interface NXMMediaSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMMediaSettings
	{
		// @property (readonly, nonatomic) _Bool isEnabled;
		[Export("isEnabled")]
		bool IsEnabled { get; }

		// @property (readonly, nonatomic) _Bool isSuspended;
		[Export("isSuspended")]
		bool IsSuspended { get; }
	}

	// @interface NXMLeg : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMLeg : INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nonnull uuid;
		[Export("uuid")]
		string Uuid { get; set; }

		// @property (assign, nonatomic) NXMLegType type;
		[Export("type", ArgumentSemantic.Assign)]
		NXMLegType Type { get; set; }

		// @property (assign, nonatomic) NXMLegStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		NXMLegStatus Status { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable conversationUuid;
		[NullAllowed, Export("conversationUuid")]
		string ConversationUuid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable memberUUid;
		[NullAllowed, Export("memberUUid")]
		string MemberUUid { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable date;
		[NullAllowed, Export("date", ArgumentSemantic.Copy)]
		NSDate Date { get; set; }
	}

	// @interface NXMDirection : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMDirection
	{
		// @property (assign, nonatomic) NXMDirectionType type;
		[Export("type", ArgumentSemantic.Assign)]
		NXMDirectionType Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable data;
		[NullAllowed, Export("data")]
		string Data { get; set; }
	}

	// @interface NXMChannel : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMChannel
	{
		// @property (readonly, nonatomic) NXMDirection * _Nonnull from;
		[Export("from")]
		NXMDirection From { get; }

		// @property (readonly, nonatomic) NXMDirection * _Nullable to;
		[NullAllowed, Export("to")]
		NXMDirection To { get; }

		// @property (readonly, nonatomic) NXMLeg * _Nullable leg;
		[NullAllowed, Export("leg")]
		NXMLeg Leg { get; }
	}

	// @interface NXMInitiator : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMInitiator
	{
		// @property (readonly, nonatomic) BOOL isSystem;
		[Export("isSystem")]
		bool IsSystem { get; }

		// @property (copy, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export("userId")]
		string UserId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable memberId;
		[NullAllowed, Export("memberId")]
		string MemberId { get; set; }

		// @property (copy, nonatomic) NSDate * _Nonnull time;
		[Export("time", ArgumentSemantic.Copy)]
		NSDate Time { get; set; }
	}

	// @interface NXMMember : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMMember
	{
		// @property (copy, nonatomic) NSString * _Nonnull conversationUuid;
		[Export("conversationUuid")]
		string ConversationUuid { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull memberUuid;
		[Export("memberUuid")]
		string MemberUuid { get; set; }

		// @property (readonly, nonatomic) NXMUser * _Nonnull user;
		[Export("user")]
		NXMUser User { get; }

		// @property (readonly, nonatomic) NXMMemberState state;
		[Export("state")]
		NXMMemberState State { get; }

		// @property (readonly, nonatomic) NXMMediaSettings * _Nullable media;
		[NullAllowed, Export("media")]
		NXMMediaSettings Media { get; }

		// @property (readonly, nonatomic) NXMChannel * _Nullable channel;
		[NullAllowed, Export("channel")]
		NXMChannel Channel { get; }
	}

	// @interface NXMEvent : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMEvent
	{
		// @property (copy, nonatomic) NSString * _Nonnull conversationUuid;
		[Export("conversationUuid")]
		string ConversationUuid { get; set; }

		// @property (readonly, nonatomic) NXMMember * _Nullable fromMember;
		[NullAllowed, Export("fromMember")]
		NXMMember FromMember { get; }

		// @property (copy, nonatomic) NSDate * _Nonnull creationDate;
		[Export("creationDate", ArgumentSemantic.Copy)]
		NSDate CreationDate { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable deletionDate;
		[NullAllowed, Export("deletionDate", ArgumentSemantic.Copy)]
		NSDate DeletionDate { get; set; }

		// @property (readonly, nonatomic) NXMEventType type;
		[Export("type")]
		NXMEventType Type { get; }

		// @property (readonly, nonatomic) NSInteger uuid;
		[Export("uuid")]
		nint Uuid { get; }
	}

	// @interface NXMMessageEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMMessageEvent
	{
		// @property (readonly, nonatomic) NSDictionary<NSNumber *,NSDictionary<NSString *,NSDate *> *> * _Nonnull state;
		[Export("state")]
		NSDictionary<NSNumber, NSDictionary<NSString, NSDate>> State { get; }
	}

	// @interface NXMTextEvent : NXMMessageEvent
	[BaseType(typeof(NXMMessageEvent))]
	interface NXMTextEvent
	{
		// @property (readonly, nonatomic) NSString * _Nullable text;
		[NullAllowed, Export("text")]
		string Text { get; }
	}

	// @interface NXMTextTypingEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMTextTypingEvent
	{
		// @property (readonly, nonatomic) NXMTextTypingEventStatus status;
		[Export("status")]
		NXMTextTypingEventStatus Status { get; }
	}

	// @interface NXMImageInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMImageInfo
	{
		// @property (readonly, nonatomic) NSString * _Nonnull imageUuid;
		[Export("imageUuid")]
		string ImageUuid { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull url;
		[Export("url")]
		NSUrl Url { get; }

		// @property (readonly) NSInteger sizeInBytes;
		[Export("sizeInBytes")]
		nint SizeInBytes { get; }

		// @property (readonly) NXMImageSize size;
		[Export("size")]
		NXMImageSize Size { get; }
	}

	// @interface NXMImageEvent : NXMMessageEvent
	[BaseType(typeof(NXMMessageEvent))]
	interface NXMImageEvent
	{
		// @property (readonly, nonatomic) NSString * _Nonnull imageUuid;
		[Export("imageUuid")]
		string ImageUuid { get; }

		// @property (readonly, nonatomic) NXMImageInfo * _Nonnull mediumImage;
		[Export("mediumImage")]
		NXMImageInfo MediumImage { get; }

		// @property (readonly, nonatomic) NXMImageInfo * _Nonnull originalImage;
		[Export("originalImage")]
		NXMImageInfo OriginalImage { get; }

		// @property (readonly, nonatomic) NXMImageInfo * _Nonnull thumbnailImage;
		[Export("thumbnailImage")]
		NXMImageInfo ThumbnailImage { get; }
	}

	// @interface NXMMessageStatusEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMMessageStatusEvent
	{
		// @property (readonly, nonatomic) NSInteger referenceEventUuid;
		[Export("referenceEventUuid")]
		nint ReferenceEventUuid { get; }

		// @property (readonly, nonatomic) NXMMessageStatusType status;
		[Export("status")]
		NXMMessageStatusType Status { get; }
	}

	// @interface NXMMemberEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMMemberEvent
	{
		// @property (readonly, nonatomic) NXMMember * _Nonnull member;
		[Export("member")]
		NXMMember Member { get; }

		// @property (nonatomic) NXMMemberState state;
		[Export("state", ArgumentSemantic.Assign)]
		NXMMemberState State { get; set; }

		// @property (readonly, nonatomic) NXMMediaSettings * _Nullable media;
		[NullAllowed, Export("media")]
		NXMMediaSettings Media { get; }

		// @property (readonly, nonatomic) NXMChannel * _Nullable channel;
		[NullAllowed, Export("channel")]
		NXMChannel Channel { get; }

		// @property (copy, nonatomic) NSString * _Nullable knockingId;
		[NullAllowed, Export("knockingId")]
		string KnockingId { get; set; }
	}

	// @interface NXMMediaEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMMediaEvent
	{
		// @property (readonly, nonatomic) _Bool isEnabled;
		[Export("isEnabled")]
		bool IsEnabled { get; }

		// @property (readonly, nonatomic) _Bool isSuspended;
		[Export("isSuspended")]
		bool IsSuspended { get; }
	}

	// @interface NXMDTMFEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMDTMFEvent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable digit;
		[NullAllowed, Export("digit")]
		string Digit { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable duration;
		[NullAllowed, Export("duration", ArgumentSemantic.Copy)]
		NSNumber Duration { get; }
	}

	// @interface NXMLegStatusEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMLegStatusEvent
	{
		// @property (readonly, nonatomic) NSMutableArray<NXMLeg *> * _Nonnull history;
		[Export("history")]
		NSMutableArray<NXMLeg> History { get; }

		// @property (readonly, nonatomic) NXMLeg * _Nonnull current;
		[Export("current")]
		NXMLeg Current { get; }
	}

	// @interface NXMCustomEvent : NXMEvent
	[BaseType(typeof(NXMEvent))]
	interface NXMCustomEvent
	{
		// @property (copy, nonatomic) NSString * _Nullable customType;
		[NullAllowed, Export("customType")]
		string CustomType { get; set; }

		// @property (readonly, nonatomic) NSString * _Nullable data;
		[NullAllowed, Export("data")]
		string Data { get; }
	}

	// @protocol NXMConversationUpdateDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface NXMConversationUpdateDelegate
	{
		// @required -(void)conversation:(NXMConversation * _Nonnull)conversation didUpdateMember:(NXMMember * _Nonnull)member withType:(NXMMemberUpdateType)type;
		[Abstract]
		[Export("conversation:didUpdateMember:withType:")]
		void DidUpdateMember(NXMConversation conversation, NXMMember member, NXMMemberUpdateType type);
	}

	// @protocol NXMConversationDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface NXMConversationDelegate
	{
		// @required -(void)conversation:(NXMConversation * _Nonnull)conversation didReceive:(NSError * _Nonnull)error;
		[Abstract]
		[Export("conversation:didReceive:")]
		void DidReceive(NXMConversation conversation, NSError error);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveCustomEvent:(NXMCustomEvent * _Nonnull)event;
		[Export("conversation:didReceiveCustomEvent:")]
		void DidReceiveCustomEvent(NXMConversation conversation, NXMCustomEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveTextEvent:(NXMTextEvent * _Nonnull)event;
		[Export("conversation:didReceiveTextEvent:")]
		void DidReceiveTextEvent(NXMConversation conversation, NXMTextEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveImageEvent:(NXMImageEvent * _Nonnull)event;
		[Export("conversation:didReceiveImageEvent:")]
		void DidReceiveImageEvent(NXMConversation conversation, NXMImageEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveMessageStatusEvent:(NXMMessageStatusEvent * _Nonnull)event;
		[Export("conversation:didReceiveMessageStatusEvent:")]
		void DidReceiveMessageStatusEvent(NXMConversation conversation, NXMMessageStatusEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveTypingEvent:(NXMTextTypingEvent * _Nonnull)event;
		[Export("conversation:didReceiveTypingEvent:")]
		void DidReceiveTypingEvent(NXMConversation conversation, NXMTextTypingEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveMemberEvent:(NXMMemberEvent * _Nonnull)event;
		[Export("conversation:didReceiveMemberEvent:")]
		void DidReceiveMemberEvent(NXMConversation conversation, NXMMemberEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveLegStatusEvent:(NXMLegStatusEvent * _Nonnull)event;
		[Export("conversation:didReceiveLegStatusEvent:")]
		void DidReceiveLegStatusEvent(NXMConversation conversation, NXMLegStatusEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveMediaEvent:(NXMMediaEvent * _Nonnull)event;
		[Export("conversation:didReceiveMediaEvent:")]
		void DidReceiveMediaEvent(NXMConversation conversation, NXMMediaEvent @event);

		// @optional -(void)conversation:(NXMConversation * _Nonnull)conversation didReceiveDTMFEvent:(NXMDTMFEvent * _Nonnull)event;
		[Export("conversation:didReceiveDTMFEvent:")]
		void DidReceiveDTMFEvent(NXMConversation conversation, NXMDTMFEvent @event);
	}

	// @interface NXMPage : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMPage
	{
		// @property (readonly, assign, nonatomic) NSUInteger size;
		[Export("size")]
		nuint Size { get; }

		// @property (readonly, assign, nonatomic) NXMPageOrder order;
		[Export("order", ArgumentSemantic.Assign)]
		NXMPageOrder Order { get; }

		// -(BOOL)hasNextPage;
		[Export("hasNextPage")]
		bool HasNextPage { get; }

		// -(BOOL)hasPreviousPage;
		[Export("hasPreviousPage")]
		bool HasPreviousPage { get; }
	}

	// @interface NXMEventsPage : NXMPage
	[BaseType(typeof(NXMPage))]
	interface NXMEventsPage
	{
		// @property (readonly, nonatomic) NSArray<NXMEvent *> * _Nonnull events;
		[Export("events")]
		NXMEvent[] Events { get; }

		// -(void)nextPage:(void (^ _Nonnull)(NSError * _Nullable, NXMEventsPage * _Nullable))completionHandler;
		[Export("nextPage:")]
		void NextPage(Action<NSError, NXMEventsPage> completionHandler);

		// -(void)previousPage:(void (^ _Nonnull)(NSError * _Nullable, NXMEventsPage * _Nullable))completionHandler;
		[Export("previousPage:")]
		void PreviousPage(Action<NSError, NXMEventsPage> completionHandler);
	}

	// @interface NXMConversation : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMConversation
	{
		// @property (readonly, nonatomic) NSString * _Nonnull uuid;
		[Export("uuid")]
		string Uuid { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export("displayName")]
		string DisplayName { get; }

		// @property (readonly, nonatomic) NSInteger lastEventId;
		[Export("lastEventId")]
		nint LastEventId { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull creationDate;
		[Export("creationDate")]
		NSDate CreationDate { get; }

		// @property (readonly, nonatomic) NXMMember * _Nullable myMember;
		[NullAllowed, Export("myMember")]
		NXMMember MyMember { get; }

		// @property (readonly, nonatomic) NSArray<NXMMember *> * _Nonnull allMembers;
		[Export("allMembers")]
		NXMMember[] AllMembers { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		NXMConversationDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<NXMConversationDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[Wrap("WeakUpdatesDelegate")]
		[NullAllowed]
		NXMConversationUpdateDelegate UpdatesDelegate { get; set; }

		// @property (nonatomic, weak) id<NXMConversationUpdateDelegate> _Nullable updatesDelegate;
		[NullAllowed, Export("updatesDelegate", ArgumentSemantic.Weak)]
		NSObject WeakUpdatesDelegate { get; set; }

		// -(void)inviteMemberWithUsername:(NSString * _Nonnull)username completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export("inviteMemberWithUsername:completion:")]
		void InviteMemberWithUsername(string username, [NullAllowed] Action<NSError> completion);

		// -(void)join:(void (^ _Nullable)(NSError * _Nullable, NXMMember * _Nullable))completionHandler;
		[Export("join:")]
		void Join([NullAllowed] Action<NSError, NXMMember> completionHandler);

		// -(void)joinMemberWithUsername:(NSString * _Nonnull)username completion:(void (^ _Nullable)(NSError * _Nullable, NXMMember * _Nullable))completion;
		[Export("joinMemberWithUsername:completion:")]
		void JoinMemberWithUsername(string username, [NullAllowed] Action<NSError, NXMMember> completion);

		// -(void)leave:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("leave:")]
		void Leave([NullAllowed] Action<NSError> completionHandler);

		// -(void)kickMemberWithMemberId:(NSString * _Nonnull)memberId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export("kickMemberWithMemberId:completion:")]
		void KickMemberWithMemberId(string memberId, [NullAllowed] Action<NSError> completion);

		// -(void)enableMedia;
		[Export("enableMedia")]
		void EnableMedia();

		// -(void)disableMedia;
		[Export("disableMedia")]
		void DisableMedia();

		// -(void)sendCustomWithEvent:(NSString * _Nonnull)customType data:(NSDictionary * _Nonnull)data completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendCustomWithEvent:data:completionHandler:")]
		void SendCustomWithEvent(string customType, NSDictionary data, [NullAllowed] Action<NSError> completionHandler);

		// -(void)sendText:(NSString * _Nonnull)text completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendText:completionHandler:")]
		void SendText(string text, [NullAllowed] Action<NSError> completionHandler);

		// -(void)sendAttachmentWithType:(NXMAttachmentType)type name:(NSString * _Nonnull)name data:(NSData * _Nonnull)data completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendAttachmentWithType:name:data:completionHandler:")]
		void SendAttachmentWithType(NXMAttachmentType type, string name, NSData data, [NullAllowed] Action<NSError> completionHandler);

		// -(void)sendMarkSeenMessage:(NSInteger)message completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendMarkSeenMessage:completionHandler:")]
		void SendMarkSeenMessage(nint message, [NullAllowed] Action<NSError> completionHandler);

		// -(void)sendStartTyping:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendStartTyping:")]
		void SendStartTyping([NullAllowed] Action<NSError> completionHandler);

		// -(void)sendStopTyping:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("sendStopTyping:")]
		void SendStopTyping([NullAllowed] Action<NSError> completionHandler);

		// -(void)getEventsPage:(void (^ _Nullable)(NSError * _Nullable, NXMEventsPage * _Nullable))completionHandler;
		[Export("getEventsPage:")]
		void GetEventsPage([NullAllowed] Action<NSError, NXMEventsPage> completionHandler);

		// -(void)getEventsPageWithSize:(NSUInteger)size order:(NXMPageOrder)order completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMEventsPage * _Nullable))completionHandler;
		[Export("getEventsPageWithSize:order:completionHandler:")]
		void GetEventsPageWithSize(nuint size, NXMPageOrder order, [NullAllowed] Action<NSError, NXMEventsPage> completionHandler);

		// -(void)getEventsPageWithSize:(NSUInteger)size order:(NXMPageOrder)order eventType:(NSString * _Nullable)eventType completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMEventsPage * _Nullable))completionHandler;
		[Export("getEventsPageWithSize:order:eventType:completionHandler:")]
		void GetEventsPageWithSize(nuint size, NXMPageOrder order, [NullAllowed] string eventType, [NullAllowed] Action<NSError, NXMEventsPage> completionHandler);
	}

	// @interface NXMCallMember : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMCallMember : INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nonnull memberId;
		[Export("memberId")]
		string MemberId { get; set; }

		// @property (readonly, nonatomic) NXMUser * _Nonnull user;
		[Export("user")]
		NXMUser User { get; }

		// @property (readonly, nonatomic) NXMChannel * _Nullable channel;
		[NullAllowed, Export("channel")]
		NXMChannel Channel { get; }

		// @property (readonly, nonatomic) BOOL isMuted;
		[Export("isMuted")]
		bool IsMuted { get; }

		// @property (readonly, nonatomic) NXMCallMemberStatus status;
		[Export("status")]
		NXMCallMemberStatus Status { get; }

		// @property (copy, nonatomic) NSString * _Nonnull statusDescription;
		[Export("statusDescription")]
		string StatusDescription { get; set; }

		// -(void)hold:(BOOL)isHold;
		[Export("hold:")]
		void Hold(bool isHold);

		// -(void)mute:(BOOL)isMute;
		[Export("mute:")]
		void Mute(bool isMute);

		// -(void)earmuff:(BOOL)isEarmuff;
		[Export("earmuff:")]
		void Earmuff(bool isEarmuff);
	}

	// typedef void (^NXMSuccessCallback)();
	delegate void NXMSuccessCallback();

	// typedef void (^NXMSuccessCallbackWithId)(NSString * _Nullable);
	delegate void NXMSuccessCallbackWithId([NullAllowed] string arg0);

	// typedef void (^NXMSuccessCallbackWithObject)(NSObject * _Nullable);
	delegate void NXMSuccessCallbackWithObject([NullAllowed] NSObject arg0);

	// typedef void (^NXMSuccessCallbackWithObjects)(NSArray * _Nullable);
	delegate void NXMSuccessCallbackWithObjects([NullAllowed] NSObject[] arg0);

	// typedef void (^NXMErrorCallback)(NSError * _Nullable);
	delegate void NXMErrorCallback([NullAllowed] NSError arg0);

	// typedef void (^NXMCompletionCallback)(NSError * _Nullable);
	delegate void NXMCompletionCallback([NullAllowed] NSError arg0);

	// @protocol NXMCallDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface NXMCallDelegate
	{
		// @required -(void)call:(NXMCall * _Nonnull)call didUpdate:(NXMCallMember * _Nonnull)callMember withStatus:(NXMCallMemberStatus)status;
		[Abstract]
		[Export("call:didUpdate:withStatus:")]
		void DidUpdate(NXMCall call, NXMCallMember callMember, NXMCallMemberStatus status);

		// @required -(void)call:(NXMCall * _Nonnull)call didUpdate:(NXMCallMember * _Nonnull)callMember isMuted:(BOOL)muted;
		[Abstract]
		[Export("call:didUpdate:isMuted:")]
		void DidUpdate(NXMCall call, NXMCallMember callMember, bool muted);

		// @required -(void)call:(NXMCall * _Nonnull)call didReceive:(NSError * _Nonnull)error;
		[Abstract]
		[Export("call:didReceive:")]
		void DidReceive(NXMCall call, NSError error);

		// @optional -(void)call:(NXMCall * _Nonnull)call didReceive:(NSString * _Nonnull)dtmf fromCallMember:(NXMCallMember * _Nullable)callMember;
		[Export("call:didReceive:fromCallMember:")]
		void DidReceive(NXMCall call, string dtmf, [NullAllowed] NXMCallMember callMember);
	}

	// @interface NXMCall : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMCall
	{
		// @property (readonly, nonatomic) NSMutableArray<NXMCallMember *> * _Nonnull otherCallMembers;
		[Export("otherCallMembers")]
		NSMutableArray<NXMCallMember> OtherCallMembers { get; }

		// @property (readonly, nonatomic) NXMCallMember * _Nonnull myCallMember;
		[Export("myCallMember")]
		NXMCallMember MyCallMember { get; }

		// -(void)setDelegate:(id<NXMCallDelegate> _Nonnull)delegate;
		[Export("setDelegate:")]
		void SetDelegate(NXMCallDelegate @delegate);

		// -(void)answer:(NXMCompletionCallback _Nullable)completionHandler;
		[Export("answer:")]
		void Answer([NullAllowed] NXMCompletionCallback completionHandler);

		// -(void)reject:(NXMCompletionCallback _Nullable)completionHandler;
		[Export("reject:")]
		void Reject([NullAllowed] NXMCompletionCallback completionHandler);

		// -(void)addCallMemberWithUsername:(NSString * _Nonnull)username completionHandler:(NXMCompletionCallback _Nullable)completionHandler;
		[Export("addCallMemberWithUsername:completionHandler:")]
		void AddCallMemberWithUsername(string username, [NullAllowed] NXMCompletionCallback completionHandler);

		// -(void)addCallMemberWithNumber:(NSString * _Nonnull)number completionHandler:(NXMCompletionCallback _Nullable)completionHandler;
		[Export("addCallMemberWithNumber:completionHandler:")]
		void AddCallMemberWithNumber(string number, [NullAllowed] NXMCompletionCallback completionHandler);

		// -(void)sendDTMF:(NSString * _Nonnull)dtmf;
		[Export("sendDTMF:")]
		void SendDTMF(string dtmf);

		// -(void)hangup;
		[Export("hangup")]
		void Hangup();
	}

	// @interface NXMConversationsPage : NXMPage
	[BaseType(typeof(NXMPage))]
	interface NXMConversationsPage
	{
		// @property (readonly, nonatomic) NSArray<NXMConversation *> * _Nonnull conversations;
		[Export("conversations")]
		NXMConversation[] Conversations { get; }

		// -(void)nextPage:(void (^ _Nonnull)(NSError * _Nullable, NXMConversationsPage * _Nullable))completionHandler;
		[Export("nextPage:")]
		void NextPage(Action<NSError, NXMConversationsPage> completionHandler);

		// -(void)previousPage:(void (^ _Nonnull)(NSError * _Nullable, NXMConversationsPage * _Nullable))completionHandler;
		[Export("previousPage:")]
		void PreviousPage(Action<NSError, NXMConversationsPage> completionHandler);
	}

	// @interface NXMClientConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMClientConfig
	{
		// @property (readonly, nonatomic) NSString * _Nonnull apiUrl;
		[Export("apiUrl")]
		string ApiUrl { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull websocketUrl;
		[Export("websocketUrl")]
		string WebsocketUrl { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull ipsUrl;
		[Export("ipsUrl")]
		string IpsUrl { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull iceServerUrls;
		[Export("iceServerUrls")]
		string[] IceServerUrls { get; }

		// -(instancetype _Nonnull)initWithApiUrl:(NSString * _Nonnull)apiURL websocketUrl:(NSString * _Nonnull)websocketUrl ipsUrl:(NSString * _Nonnull)ipsUrl;
		[Export("initWithApiUrl:websocketUrl:ipsUrl:")]
		IntPtr Constructor(string apiURL, string websocketUrl, string ipsUrl);

		// -(instancetype _Nonnull)initWithApiUrl:(NSString * _Nonnull)apiURL websocketUrl:(NSString * _Nonnull)websocketUrl ipsUrl:(NSString * _Nonnull)ipsUrl iceServerUrls:(NSArray<NSString *> * _Nonnull)iceServerUrls;
		[Export("initWithApiUrl:websocketUrl:ipsUrl:iceServerUrls:")]
		IntPtr Constructor(string apiURL, string websocketUrl, string ipsUrl, string[] iceServerUrls);

		// +(NXMClientConfig * _Nonnull)LON;
		[Static]
		[Export("LON")]
		NXMClientConfig LON { get; }

		// +(NXMClientConfig * _Nonnull)SNG;
		[Static]
		[Export("SNG")]
		NXMClientConfig SNG { get; }

		// +(NXMClientConfig * _Nonnull)DAL;
		[Static]
		[Export("DAL")]
		NXMClientConfig DAL { get; }

		// +(NXMClientConfig * _Nonnull)WDC;
		[Static]
		[Export("WDC")]
		NXMClientConfig WDC { get; }
	}

	// @interface NXMPushPayload : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMPushPayload
	{
		// @property (readonly, nonatomic) NSDictionary * _Nullable customData;
		[NullAllowed, Export("customData")]
		NSDictionary CustomData { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nullable eventData;
		[NullAllowed, Export("eventData")]
		NSDictionary EventData { get; }

		// @property (readonly, nonatomic) NXMPushTemplate template;
		[Export("template")]
		NXMPushTemplate Template { get; }
	}

	// @interface NXMClient : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMClient
	{
		// @property (readonly, nonatomic, class) NXMClient * _Nonnull shared;
		[Static]
		[Export("shared")]
		NXMClient Shared { get; }

		// @property (readonly, getter = getConnectionStatus, assign, nonatomic) NXMConnectionStatus connectionStatus;
		[Export("connectionStatus", ArgumentSemantic.Assign)]
		NXMConnectionStatus ConnectionStatus { [Bind("getConnectionStatus")] get; }

		// @property (readonly, getter = getUser, nonatomic) NXMUser * _Nullable user;
		[NullAllowed, Export("user")]
		NXMUser User { [Bind("getUser")] get; }

		// @property (readonly, getter = getToken, nonatomic) NSString * _Nullable authToken;
		[NullAllowed, Export("authToken")]
		string AuthToken { [Bind("getToken")] get; }

		// @property (readonly, getter = getConfiguration, nonatomic) NXMClientConfig * _Nullable configuration;
		[NullAllowed, Export("configuration")]
		NXMClientConfig Configuration { [Bind("getConfiguration")] get; }

		// +(void)setConfiguration:(NXMClientConfig * _Nonnull)configuration;
		[Static]
		[Export("setConfiguration:")]
		void SetConfiguration(NXMClientConfig configuration);

		// -(void)setDelegate:(id<NXMClientDelegate> _Nonnull)delegate;
		[Export("setDelegate:")]
		void SetDelegate(NXMClientDelegate @delegate);

		// -(void)loginWithAuthToken:(NSString * _Nonnull)authToken;
		[Export("loginWithAuthToken:")]
		void LoginWithAuthToken(string authToken);

		// -(void)updateAuthToken:(NSString * _Nonnull)authToken;
		[Export("updateAuthToken:")]
		void UpdateAuthToken(string authToken);

		// -(void)logout;
		[Export("logout")]
		void Logout();

		// -(void)getConversationWithUuid:(NSString * _Nonnull)uuid completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMConversation * _Nullable))completionHandler;
		[Export("getConversationWithUuid:completionHandler:")]
		void GetConversationWithUuid(string uuid, [NullAllowed] Action<NSError, NXMConversation> completionHandler);

		// -(void)createConversationWithName:(NSString * _Nonnull)name completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMConversation * _Nullable))completionHandler;
		[Export("createConversationWithName:completionHandler:")]
		void CreateConversationWithName(string name, [NullAllowed] Action<NSError, NXMConversation> completionHandler);

		// -(void)getConversationsPageWithSize:(NSInteger)size order:(NXMPageOrder)order completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMConversationsPage * _Nullable))completionHandler __attribute__((deprecated("use getConversationsPageWithSize:(NSInteger) order:(NXMPageOrder) filter:(NSString*) completionHandler instead")));
		[Export("getConversationsPageWithSize:order:completionHandler:")]
		void GetConversationsPageWithSize(nint size, NXMPageOrder order, [NullAllowed] Action<NSError, NXMConversationsPage> completionHandler);

		// -(void)getConversationsPageWithSize:(NSInteger)size order:(NXMPageOrder)order filter:(NSString * _Nullable)filter completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMConversationsPage * _Nullable))completionHandler;
		[Export("getConversationsPageWithSize:order:filter:completionHandler:")]
		void GetConversationsPageWithSize(nint size, NXMPageOrder order, [NullAllowed] string filter, [NullAllowed] Action<NSError, NXMConversationsPage> completionHandler);

		// -(void)call:(NSString * _Nonnull)callee callHandler:(NXMCallHandler)callHandler completionHandler:(void (^ _Nullable)(NSError * _Nullable, NXMCall * _Nullable))completionHandler;
		[Export("call:callHandler:completionHandler:")]
		void Call(string callee, NXMCallHandler callHandler, [NullAllowed] Action<NSError, NXMCall> completionHandler);

		// -(void)enablePushNotificationsWithPushKitToken:(NSData * _Nullable)pushKitToken userNotificationToken:(NSData * _Nullable)userNotificationToken isSandbox:(BOOL)isSandbox completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("enablePushNotificationsWithPushKitToken:userNotificationToken:isSandbox:completionHandler:")]
		void EnablePushNotificationsWithPushKitToken([NullAllowed] NSData pushKitToken, [NullAllowed] NSData userNotificationToken, bool isSandbox, [NullAllowed] Action<NSError> completionHandler);

		// -(void)disablePushNotifications:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export("disablePushNotifications:")]
		void DisablePushNotifications([NullAllowed] Action<NSError> completionHandler);

		// -(BOOL)isNexmoPushWithUserInfo:(NSDictionary * _Nonnull)userInfo;
		[Export("isNexmoPushWithUserInfo:")]
		bool IsNexmoPushWithUserInfo(NSDictionary userInfo);

		// -(void)processNexmoPushWithUserInfo:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler __attribute__((deprecated("Use processNexmoPushPayload instead.")));
		[Export("processNexmoPushWithUserInfo:completionHandler:")]
		void ProcessNexmoPushWithUserInfo(NSDictionary userInfo, [NullAllowed] Action<NSError> completionHandler);

		// -(NXMPushPayload * _Nullable)processNexmoPushPayload:(NSDictionary * _Nonnull)pushInfo;
		[Export("processNexmoPushPayload:")]
		[return: NullAllowed]
		NXMPushPayload ProcessNexmoPushPayload(NSDictionary pushInfo);
	}

	// @interface NXMLogger : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMLogger
	{
		// +(void)setLogLevel:(NXMLoggerLevel)logLevel;
		[Static]
		[Export("setLogLevel:")]
		void SetLogLevel(NXMLoggerLevel logLevel);

		// +(NSMutableArray * _Nonnull)getLogFileNames;
		[Static]
		[Export("getLogFileNames")]
		NSMutableArray LogFileNames { get; }
	}

	// @interface NXMHelper : NSObject
	[BaseType(typeof(NSObject))]
	interface NXMHelper
	{
		// +(NSString * _Nonnull)descriptionForEventType:(NXMEventType)eventType;
		[Static]
		[Export("descriptionForEventType:")]
		string DescriptionForEventType(NXMEventType eventType);
	}
}