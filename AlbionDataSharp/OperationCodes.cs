﻿namespace AlbionDataSharp
{
    public enum OperationCodes
    {
        Unused = 0,
        Ping,
        Join,
        VersionedOperation,
        CreateAccount,
        Login,
        CreateGuestAccount,
        SendCrashLog,
        SendTraceRoute,
        SendVfxStats,
        SendGamePingInfo,
        CreateCharacter,
        DeleteCharacter,
        SelectCharacter,
        AcceptPopups,
        RedeemKeycode,
        GetGameServerByCluster,
        GetShopPurchaseUrl,
        GetReferralSeasonDetails,
        GetReferralLink,
        GetShopTilesForCategory,
        Move = 21,
        AttackStart,
        CastStart,
        CastCancel,
        TerminateToggleSpell,
        ChannelingCancel,
        AttackBuildingStart,
        InventoryDestroyItem,
        InventoryMoveItem = 29, // map[0:4 1:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 2:14 4:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 5:14 253:29]
        InventoryRecoverItem,
        InventoryRecoverAllItems,
        InventorySplitStack,
        InventorySplitStackInto,
        GetClusterData,
        ChangeCluster = 35, // Request: map[0:2 1: 2:[-1] 253:36 255:114] - Response: map[0:4000 253:36 255:114]
        ConsoleCommand,
        ChatMessage,
        ReportClientError,
        RegisterToObject = 39,
        UnRegisterFromObject = 40,
        CraftBuildingChangeSettings,
        CraftBuildingTakeMoney,
        RepairBuildingChangeSettings,
        RepairBuildingTakeMoney,
        ActionBuildingChangeSettings,
        HarvestStart,
        HarvestCancel,
        TakeSilver = 49, // map[0:638028282819317254 1:442 2:2 3:3 4:530000 5:[1571] 253:48] 
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        InstallResourceStart,
        InstallResourceCancel,
        InstallSilver,
        BuildingFillNutrition,
        BuildingChangeRenovationState,
        BuildingBuySkin,
        BuildingClaim,
        BuildingGiveup,
        BuildingNutritionSilverStorageDeposit,
        BuildingNutritionSilverStorageWithdraw,
        BuildingNutritionSilverRewardSet,
        ConstructionSiteCreate,
        PlaceableObjectPlace,
        PlaceableObjectPlaceCancel,
        PlaceableObjectPickup,
        FurnitureObjectUse,
        FarmableHarvest,
        FarmableFinishGrownItem,
        FarmableDestroy,
        FarmableGetProduct,
        FarmableFill,
        TearDownConstructionSite,
        CastleGateUse,
        AuctionCreateOffer,
        AuctionCreateRequest,
        AuctionGetOffers = 76,
        AuctionGetRequests = 77,
        AuctionBuyOffer = 78,
        AuctionAbortAuction,
        AuctionModifyAuction,
        AuctionAbortOffer,
        AuctionAbortRequest,
        AuctionSellRequest,
        AuctionGetFinishedAuctions,
        AuctionGetFinishedAuctionsCount,
        AuctionFetchAuction,
        AuctionGetMyOpenOffers,
        AuctionGetMyOpenRequests,
        AuctionGetMyOpenAuctions,
        AuctionGetItemAverageStats,
        AuctionGetItemAverageValue,
        ContainerOpen, // map[0: ObjectId = 405 1:1 2: ObjectGuid = [-46 37 -21 125 -40 -77 125 76 -96 -6 39 120 -46 -21 11 -39] 253:92]
        ContainerClose,
        ContainerManageSubContainer,
        Respawn,
        Suicide,
        JoinGuild,
        LeaveGuild,
        CreateGuild,
        InviteToGuild,
        DeclineGuildInvitation,
        KickFromGuild,
        InstantJoinGuild,
        DuellingChallengePlayer,
        DuellingAcceptChallenge,
        DuellingDenyChallenge,
        ChangeClusterTax,
        ClaimTerritory,
        GiveUpTerritory,
        ChangeTerritoryAccessRights,
        GetMonolithInfo,
        GetClaimInfo,
        GetAttackInfo,
        GetTerritorySeasonPoints,
        GetAttackSchedule,
        ScheduleAttack,
        GetMatches,
        GetMatchDetails,
        JoinMatch,
        LeaveMatch,
        ChangeChatSettings,
        LogoutStart,
        LogoutCancel,
        ClaimOrbStart,
        ClaimOrbCancel,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningCancel,
        DepositToGuildAccount,
        WithdrawalFromAccount,
        ChangeGuildPayUpkeepFlag,
        ChangeGuildTax,
        GetMyTerritories,
        MorganaCommand,
        GetServerInfo,
        SubscribeToCluster,
        AnswerMercenaryInvitation,
        GetCharacterEquipment = 137,
        GetCharacterSteamAchievements,
        GetCharacterStats,
        GetKillHistoryDetails,
        LearnMasteryLevel,
        ReSpecAchievement,
        ChangeAvatar,
        GetRankings,
        GetRank,
        GetGvgSeasonRankings,
        GetGvgSeasonRank,
        GetGvgSeasonHistoryRankings,
        GetGvgSeasonGuildMemberHistory,
        KickFromGvGMatch,
        GetCrystalLeagueDailySeasonPoints,
        GetChestLogs,
        GetAccessRightLogs,
        GetGuildAccountLogs,
        GetGuildAccountLogsLargeAmount,
        InviteToPlayerTrade,
        PlayerTradeCancel,
        PlayerTradeInvitationAccept,
        PlayerTradeAddItem,
        PlayerTradeRemoveItem,
        PlayerTradeAcceptTrade,
        PlayerTradeSetSilverOrGold,
        SendMiniMapPing,
        Stuck,
        BuyRealEstate,
        ClaimRealEstate,
        GiveUpRealEstate,
        ChangeRealEstateOutline,
        GetMailInfos = 169, // map[0:- 2:0 3:[MAIL_ID, MAIL_ID] 4:- 5:- 6:[CLUSTER_ID or UserName] 7:[3 3] 8:[3 3] 9:[true true]
                            // 10:[MARKETPLACE_BUYORDER_FINISHED_SUMMARY MARKETPLACE_SELLORDER_FINISHED_SUMMARY] 11:[637852747555964630 637852641241345990] 12:[false false]]
        GetMailCount,
        ReadMail = 171, //  map[0: MailId 1:QUANTITY|UNIQUE_ITEM_NAME(T4_ARMOR_CLOTH_SET3)|TOTAL_PRICE|UNIT_PRICE 2:[] 3:[] 4:[] 5:[] 6:[] 253:170]
        SendNewMail,
        DeleteMail,
        MarkMailUnread,
        ClaimAttachmentFromMail,
        ApplyToGuild,
        AnswerGuildApplication,
        RequestGuildFinderFilteredList,
        UpdateGuildRecruitmentInfo,
        RequestGuildRecruitmentInfo,
        RequestGuildFinderNameSearch,
        RequestGuildFinderRecommendedList,
        RegisterChatPeer,
        SendChatMessage,
        JoinChatChannel,
        LeaveChatChannel,
        SendWhisperMessage,
        Say,
        PlayEmote,
        StopEmote,
        GetClusterMapInfo,
        AccessRightsChangeSettings,
        Mount,
        MountCancel,
        BuyJourney,
        SetSaleStatusForEstate,
        ResolveGuildOrPlayerName,
        GetRespawnInfos,
        MakeHome,
        LeaveHome,
        ResurrectionReply,
        AllianceCreate,
        AllianceDisband,
        AllianceGetMemberInfos,
        AllianceInvite,
        AllianceAnswerInvitation,
        AllianceCancelInvitation,
        AllianceKickGuild,
        AllianceLeave,
        AllianceChangeGoldPaymentFlag,
        AllianceGetDetailInfo,
        GetIslandInfos,
        AbandonMyIsland,
        BuyMyIsland,
        BuyGuildIsland,
        AbandonGuildIsland,
        UpgradeMyIsland,
        UpgradeGuildIsland,
        MoveMyIsland,
        MoveGuildIsland,
        TerritoryFillNutrition,
        TeleportBack,
        PartyInvitePlayer,
        PartyRequestJoin,
        PartyAnswerInvitation,
        PartyAnswerJoinRequest,
        PartyLeave,
        PartyKickPlayer,
        PartyMakeLeader,
        PartyChangeLootSetting,
        PartyMarkObject,
        PartySetRole,
        GetGuildMotd,
        ExitEnterStart,
        ExitEnterCancel,
        QuestGiverRequest,
        GoldMarketGetBuyOffer,
        GoldMarketGetBuyOfferFromSilver,
        GoldMarketGetSellOffer,
        GoldMarketGetSellOfferFromSilver,
        GoldMarketBuyGold,
        GoldMarketSellGold,
        GoldMarketCreateSellOrder,
        GoldMarketCreateBuyOrder,
        GoldMarketGetInfos,
        GoldMarketCancelOrder,
        Unknown246,
        GoldMarketGetAverageInfo,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        TreasureChestUsingStart,
        TreasureChestUsingCancel,
        UseLootChest, // <- LootLogger: https://github.com/EmeraldKnight79/AO-DU-LootLogger/blob/b1ab099e0d82bdee0a87c153f4bbae324295656e/LootLogger/PacketHandler.cs#L68
        UseShrine = 248,
        UseHellgateShrine,
        LaborerStartJob,
        LaborerTakeJobLoot,
        LaborerDismiss,
        LaborerMove,
        LaborerBuyItem,
        LaborerUpgrade,
        BuyPremium,
        BuyTrial,
        RealEstateGetAuctionData,
        RealEstateBidOnAuction,
        GetSiegeCampCooldown,
        FriendInvite,
        FriendAnswerInvitation,
        FriendCancelnvitation,
        FriendRemove,
        InventoryStack,
        InventorySort,
        InventoryDropAll,
        InventoryAddToStacks,
        EquipmentItemChangeSpell,
        ExpeditionRegister,
        ExpeditionRegisterCancel,
        JoinExpedition,
        DeclineExpeditionInvitation,
        VoteStart,
        VoteDoVote,
        RatingDoRate,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        ActivateExpeditionCheckPoint,
        ArenaRegister,
        ArenaAddInvite,
        ArenaRegisterCancel,
        ArenaLeave,
        JoinArenaMatch,
        DeclineArenaInvitation,
        EnteringArenaStart,
        EnteringArenaCancel,
        ArenaCustomMatch,
        UpdateCharacterStatement,
        BoostFarmable,
        GetStrikeHistory,
        UseFunction,
        UsePortalEntrance,
        ResetPortalBinding,
        QueryPortalBinding,
        ClaimPaymentTransaction,
        ReSpecBoost = 297,
        ChangeUseFlag,
        ClientPerformanceStats,
        ExtendedHardwareStats = 300, //  map[0:NVIDIA GeForce RTX 3090 1:AMD Ryzen 7 2700X Eight-Core Processor  2:Windows 10  (10.0.0) 64bit 3:3693 4:24348 5:16293 6:DE-DE 7:Custom 8:1746 10:-1 253:303]
        ClientLowMemoryWarning,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        ClaimPowerCrystalStart,
        ClaimPowerCrystalCancel,
        TerritoryUpgradeWithPowerCrystal,
        RequestAppStoreProducts,
        VerifyProductPurchase,
        QueryGuildPlayerStats,
        QueryAllianceGuildStats,
        TrackAchievements,
        SetAchievementsAutoLearn,
        DepositItemToGuildCurrency,
        WithdrawalItemFromGuildCurrency,
        AuctionSellSpecificItemRequest = 315,
        FishingStart = 316, // 0: EventId, 2: Used fishing rod
        FishingCasting,
        FishingCast,
        FishingCatch,
        FishingPull,
        FishingGiveLine,
        FishingFinish = 322, // Request: 1: true is finished | false is failed - Response: Fishing finished
        FishingCancel = 323, // Request: Fishing canceled
        CreateGuildAccessTag,
        DeleteGuildAccessTag,
        RenameGuildAccessTag,
        FlagGuildAccessTagGuildPermission,
        AssignGuildAccessTag,
        RemoveGuildAccessTagFromPlayer,
        ModifyGuildAccessTagEditors,
        RequestPublicAccessTags,
        ChangeAccessTagPublicFlag,
        UpdateGuildAccessTag,
        SteamStartMicrotransaction,
        SteamFinishMicrotransaction,
        SteamIdHasActiveAccount,
        CheckEmailAccountState,
        LinkAccountToSteamId,
        InAppConfirmPaymentGooglePlay,
        InAppConfirmPaymentAppleAppStore,
        InAppPurchaseRequest,
        InAppPurchaseFailed,
        CharacterSubscriptionInfo,
        AccountSubscriptionInfo,
        BuyGvgSeasonBooster,
        ChangeFlaggingPrepare,
        OverCharge,
        OverChargeEnd,
        RequestTrusted,
        ChangeGuildLogo,
        PartyFinderRegisterForUpdates,
        PartyFinderUnregisterForUpdates,
        PartyFinderEnlistNewPartySearch,
        PartyFinderDeletePartySearch,
        PartyFinderChangePartySearch,
        PartyFinderChangeRole,
        PartyFinderApplyForGroup,
        PartyFinderAcceptOrDeclineApplyForGroup,
        PartyFinderGetEquipmentSnapshot,
        PartyFinderRegisterApplicants,
        PartyFinderUnregisterApplicants,
        PartyFinderFulltextSearch,
        PartyFinderRequestEquipmentSnapshot,
        GetPersonalSeasonTrackerData,
        GetPersonalSeasonPastRewardData,
        UseConsumableFromInventory,
        ClaimPersonalSeasonReward,
        EasyAntiCheatMessageToServer,
        XignCodeMessageToServer,
        BattlEyeMessageToServer,
        SetNextTutorialState,
        AddPlayerToMuteList,
        RemovePlayerFromMuteList,
        ProductShopUserEvent,
        GetVanityUnlocks,
        BuyVanityUnlocks,
        GetMountSkins,
        SetMountSkin,
        SetWardrobe,
        ChangeCustomization,
        ChangePlayerIslandData,
        GetGuildChallengePoints,
        SmartQueueJoin,
        SmartQueueLeave,
        SmartQueueSelectSpawnCluster,
        UpgradeHideout,
        InitHideoutAttackStart,
        InitHideoutAttackCancel,
        HideoutFillNutrition,
        HideoutGetInfo,
        HideoutGetOwnerInfo,
        HideoutSetTribute,
        HideoutUpgradeWithPowerCrystal,
        HideoutDeclareHQ,
        HideoutUndeclareHQ,
        HideoutGetHQRequirements,
        HideoutBoost,
        HideoutBoostConstruction,
        OpenWorldAttackScheduleStart,
        OpenWorldAttackScheduleCancel,
        OpenWorldAttackConquerStart,
        OpenWorldAttackConquerCancel,
        GetOpenWorldAttackDetails,
        GetNextOpenWorldAttackScheduleTime,
        RecoverVaultFromHideout,
        GetGuildEnergyDrainInfo,
        ChannelingUpdate,
        UseCorruptedShrine,
        RequestEstimatedMarketValue,
        LogFeedback,
        GetInfamyInfo,
        GetPartySmartClusterQueuePriority,
        SetPartySmartClusterQueuePriority,
        ClientAntiAutoClickerInfo,
        ClientBotPatternDetectionInfo,
        ClientAntiGatherClickerInfo,
        LoadoutCreate,
        LoadoutRead,
        LoadoutReadHeaders,
        LoadoutUpdate,
        LoadoutDelete,
        LoadoutOrderUpdate,
        LoadoutEquip,
        BatchUseItemCancel,
        EnlistFactionWarfare,
        GetFactionWarfareWeeklyReport,
        ClaimFactionWarfareWeeklyReport,
        GetFactionWarfareCampaignData,
        ClaimFactionWarfareItemReward,
        SendMemoryConsumption,
        PickupPowerCrystalStart,
        PickupPowerCrystalCancel,
        SetSavingChestLogsFlag,
        GetSavingChestLogsFlag,
        RegisterGuestAccount,
        ResendGuestAccountVerificationEmail,
        DoSimpleActionStart,
        DoSimpleActionCancel,
        GetGvgSeasonContributionByActivity,
        GetGvgSeasonContributionByCrystalLeague,
        GetGuildMightCategoryContribution,
        GetGuildMightCategoryOverview,
        GetPvpChallengeData,
        ClaimPvpChallengeWeeklyReward,
        GetPersonalMightStats,
        GetGvgSeasonGuildParticipationTime,
        AuctionGetLoadoutOffers = 446,
        AuctionBuyLoadoutOffer = 447,
        AccountDeletionRequest,
        AccountReactivationRequest,
        GetModerationEscalationDefiniton,
        EventBasedPopupAddSeen,
        GetItemKillHistory,
        GetVanityConsumables,
        EquipKillEmote,
        ChangeKillEmotePlayOnKnockdownSetting,
        BuyVanityConsumableCharges,
        GetArenaRankings,
        GetCrystalLeagueStatistics,
        SendOptionsLog,
        SendControlsOptionsLog,
        MistsUseImmediateReturnExit,
        MistsUseStaticEntrance,
        MistsUseCityRoadsEntrance,
        ChangeNewGuildMemberMail,
        GetNewGuildMemberMail,
        ChangeGuildFactionAllegiance,
        GetGuildFactionAllegiance,
        GuildBannerChange,
        GuildGetOptionalStats,
        GuildSetOptionalStats,
        GetPlayerInfoForStalk,
        PayGoldForCharacterTypeChange,
        QuickSellAuctionQueryAction,
        QuickSellAuctionSellAction,
        FcmTokenToServer,
        ApnsTokenToServer,
        DeathRecap,
        AuctionFetchFinishedAuctions,
        AbortAuctionFetchFinishedAuctions
    }
}
