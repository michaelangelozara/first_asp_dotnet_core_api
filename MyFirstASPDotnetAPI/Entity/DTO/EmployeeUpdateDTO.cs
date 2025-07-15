namespace MyFirstASPDotnetAPI.Entity.DTO {
    public class EmployeeUpdateDTO(string FirstName, string MiddleName, string LastName, string Email, string PhoneNumber) {
        public string FirstName { get; set; } = FirstName;

        public string MiddleName { get; set; } = MiddleName;

        public string LastName { get; set; } = LastName;

        public string Email { get; set; } = Email;

        public string? PhoneNumber { get; set; } = PhoneNumber;
    }
}
