using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ������ ��������� ���������
    /// </summary>
    [DataContract]
    public enum DocumentDeliveryStatus
    {
        /// <summary>
        /// �������� ������� ��������. 
        /// ������ ��������, ��� ������ ������ ��������, �� ��� �� ������� ��� ���������� (��� ������� ���������)
        /// </summary>
        [EnumMember]
        RecievedByService = 0x00,

        /// <summary>
        /// �������� ��������� ����������. 
        /// ���� ���������� ���������, �� ������ ��������, ��� �������� ��������� � ����� �������� ����������.
        /// ���� ���������� ��������������� � ������� ���������, �� ������ ��������, ��� ������ ������� �������� ��������� �� ��������� ��������,
        /// � ���� ������ �� �������� ��������� ��� �������� �������� ����������.
        /// </summary>
        [EnumMember]
        SentToRecipient = 0x01,

        /// <summary>
        /// �������� ��������� ����������. 
        /// ������ ��������, ��� �������� ������������� �� ���������� � �������� ���������.
        /// </summary>
        [EnumMember]
        DeliveredToRecipient = 0x2,

        /// <summary>
        /// �������� �� ��������� ����������. 
        /// ������ ��������, ��� ������������ �������� ��������� �� ������ �� �������.
        /// </summary>
        [EnumMember]
        NotDeliveredToRecipient = 0x3,
    }
}
