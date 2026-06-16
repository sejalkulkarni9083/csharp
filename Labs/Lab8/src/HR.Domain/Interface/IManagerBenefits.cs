namespace HR.Domain.Interfaces;

public interface IManagerBenefits : IBonusEligible, IAppraisable
{
    void ApproveLeave();
}