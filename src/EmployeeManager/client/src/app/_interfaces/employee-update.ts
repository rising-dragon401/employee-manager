export interface EmployeeToUpdate {
    name: string;
    email: string;
    phoneNumber: string;
    position: string;
    startDate: Date;
    endDate?: Date;
    salary?: number;
    hourlyRate?: number;
}
