import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'app/_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  model: any = {};

  constructor(
    private accountService: AccountService,
    private router: Router,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {}

  register(): void {
    this.accountService.register(this.model).subscribe({
      next: () => {
        this.toastr.success('Registration Successful!');
        this.router.navigate(['/login']); // Navigate to login after successful registration
      },
      error: (err) => {
        this.toastr.error(
          `Registration failed. Please try again. ${err.error}`
        );
      },
    });
  }

  cancel(): void {
    this.router.navigate(['/login']); // Navigate to login on cancel
  }
}
