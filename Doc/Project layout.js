Employees details sturcture project:


User =>> User profile
		=> Company === multiple owner possible
		=> Associate Company
		=>
Company =>>Associate User  
					==> project Assign ==>> 
							Project (Tick spot and bug ZERO  and assign issuse and mainntain history of project base)
								==> Project role and members
			=>Device
			=> Attendance
			=>Project 
			=>Leaves  ==>  Show to projects members
			=> Hoilday
			=> Salary
			=> Expense
			=> NOtificatication ==> 1.Notice
										 2. ENQ.     =>>>> multiple note save  accocitae =>> 
										 
User = new {
	ID int
	Userid  encryp
	username
	email
	password
	pass1
	pass2
	IsActive
	mobile 
	isEmailverify
	IsMobileVerify
	LoginAttempt
	LastLoginDate
	}
	
UserProfile= new{
Userid
Fname
lName
Mname
Father name
mothername
mobile ==> comma sepatee Array listStyleType
telno
alternate email
dob
voterid 
pan card 
adhar card
dirviind licence
Addresss
city
state
country
pincode
}

Company = new{
CompanyId
Company name
website
Email
Tin number
Registartion No
Estabish date
}

CompanyContact = new{
CompanyId
Addresss
City 
State
Country
Mobile
TelN01
Telno2
Email
}

CompanyEmployee= new{
CompanyId
UserId
DesignationId
IsAdmin
}
CompanyDesignation =new {
DesignationId
Name
CompanyId
}
CompanyDesignationRole= new{
DesignationId
RoleId
RoleName
Description
isApplied
}
CompanyDevice = new{
DeviceId
CompanyId
Name
Description
Code 
Model Number
Purchae date
Expariy date
IsActive
Status
}

EmployeeDevice= new{
DeviceId
EmployeeId
CompanyId
IssueDate
SubmitDate
}

Project = new {
CompanyId
ProjectId
ProjectName
Description
Email
Website
StartDate
EndDate
IsComplete
ProjectCost
Bugject 
EstimationDays
EstimateCost
}
PrjectWiki =new{
ProjectId
ProjectNoteId
Title
Description
}

ProjectMember=new {
ProjectId
EmployeeId
CompanyId
ProjectMemberTypeId
AssignDate
LeaveDate
}

EmployeeAttandance =new {
EmployeeId
Year
Month
MinimumTime
Overtime
TotalTime
}
EmployeesAttandanceDetail=new{
EmployeeId
Year
Month
Days
StartTime
EndTime
TotalTime
}








