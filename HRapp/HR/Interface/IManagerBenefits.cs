namespace HR.Interface;

public interface IManagerBenefits : IBonusEligible, IAppraisable
{
    void ApproveLeave();
}