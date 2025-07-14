namespace MyFirstASPDotnetAPI.Entity.DTO {
    public record EmployeeAddDTO (string FirstName, string Email, string PhoneNumber) {
        public string FirstName { get; set; } = FirstName;

        public string Email { get; set; } = Email;

        public string? PhoneNumber { get; set; } = PhoneNumber;
    }
}
