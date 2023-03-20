
using Microsoft.EntityFrameworkCore;
using Maintenance.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Machine_Movement
    {
    [Key]
    [DisplayName("Code")]
    public int MachineMovement_ID { get; set; }
    [DisplayName("note")]
    public string MachineMovement_Note { get; set; } = string.Empty;
   
    [DisplayName("Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime MachineMovement_Date { get; set; }
  
    public int MachineMovement_CreatedUserID { get; set; }
    public DateTime MachineMovement_CreatedDate { get; set; }
    public int MachineMovement_EditBy { get; set; }
    public DateTime MachineMovement_EditUserID { get; set; }

    [DisplayName("Emloyee ")]
    public int EmployeeID_FK { get; set; }
    [ForeignKey(nameof(EmployeeID_FK))]
    public Employee? Employee { get; set; }

    [DisplayName("MovementType")]
    public int MovementTypeID_FK { get; set; }
    [ForeignKey(nameof(MovementTypeID_FK))]
    public Movement_Type? Movement_Type { get; set; }
    [DisplayName("Machine Name")]
    public int MachineID_FK { get; set; }
    [ForeignKey(nameof(MachineID_FK))]
    public Machine? Machine { get; set; }
    [DisplayName("Work Type")]
    public int OrdersStatusID_FK { get; set; }
    [ForeignKey(nameof(OrdersStatusID_FK))]
    public OrdersStatus? OrdersStatus { get; set; }
    
}
