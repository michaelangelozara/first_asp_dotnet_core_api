namespace MyFirstASPDotnetAPI.Entity.model {
    public class Employee {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public decimal Salary { get; set; }

        public Employee(Guid Id, string FirstName, string MiddleName, string LastName, string Email, string? PhoneNumber, decimal Salary) {
            this.Id = Id;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Salary = Salary;
        }

        public Employee(string FirstName, string MiddleName, string LastName, string Email, string? PhoneNumber, decimal Salary) {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Salary = Salary;
        }
    }
}
