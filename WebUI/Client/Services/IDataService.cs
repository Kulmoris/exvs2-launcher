﻿using WebUI.Shared.Dto.Common;

namespace WebUI.Client.Services;

public interface IDataService
{
    public Task InitializeAsync();
    public IReadOnlyList<IdValuePair> GetDisplayOptionsSortedById();
    public IReadOnlyList<IdValuePair> GetEchelonDisplayOptionsSortedById();

    public IReadOnlyList<MobileSuit> GetMobileSuitSortedById();
    public List<MobileSuit> GetWritableMobileSuitSortedById();
    public IReadOnlyList<MobileSuit> GetCostumeMobileSuitSortedById();
    
    public MobileSuit? GetMobileSuitById(uint id);

    public IReadOnlyList<IdValuePair> GetBgmSortedById();

    public IdValuePair? GetBgmById(uint id);

    public IReadOnlyList<IdValuePair> GetGaugeSortedById();

    public IdValuePair? GetGaugeById(uint id);
    public IReadOnlyList<Familiarity> GetMsFamiliaritySortedById();
    public IReadOnlyList<Familiarity> GetNaviFamiliaritySortedById();

    public IReadOnlyList<Navigator> GetNavigatorSortedById();
    public List<Navigator> GetWritableNavigatorSortedById();

    public Navigator? GetNavigatorById(uint id);
    public IReadOnlyList<IdValuePair> GetSortedTriadSkillList();
    public IdValuePair? GetTriadSkill(uint id);
    public IReadOnlyList<IdValuePair> GetSortedTriadTeamBannerList();
    public IdValuePair? GetTriadTeamBanner(uint id);
    public IReadOnlyList<IdValuePair> GetSortedGamepadOptionList();
    public List<TriadCourseConfig> GetTriadStageConfigs();
    public IdValuePair? GetCustomizeCommentSentenceById(uint id);
    public IReadOnlyList<IdValuePair> GetCustomizeCommentSentenceSortedById();
    public IdValuePair? GetCustomizeCommentPhraseById(uint id);
    public IReadOnlyList<IdValuePair> GetCustomizeCommentPhraseSortedById();
    public GeneralPreview? GetStampById(uint id);
    public IReadOnlyList<GeneralPreview> GetStampsSortedById();
    public GeneralPreview? GetTitleById(uint id);
    public IReadOnlyList<GeneralPreview> GetTitlesSortedById();
    public GeneralPreview? GetBackgroundById(uint id);
    public IReadOnlyList<GeneralPreview> GetBackgroundsSortedById();
    public GeneralPreview? GetEffectById(uint id);
    public IReadOnlyList<GeneralPreview> GetEffectsSortedById();
    public GeneralPreview? GetOrnamentById(uint id);
    public IReadOnlyList<GeneralPreview> GetOrnamentsSortedById();
}