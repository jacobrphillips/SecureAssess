import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from './account.service';
import { tap } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';
import { User } from 'app/_models/user';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private currentUser: User | null = null;

  constructor(
    private router: Router,
    private accountService: AccountService,
    private toastr: ToastrService
  ) {}

  login(username: string, password: string): void {
    const loginModel = { username, password };
    this.accountService
      .login(loginModel)
      .pipe(
        tap((response: User) => {
          this.currentUser = response;
          localStorage.setItem('user', JSON.stringify(this.currentUser));
          this.toastr.success(`Log in successful.`);
          this.router.navigate(['/home']);
        })
      )
      .subscribe({
        error: (err) => {
          console.log(err.error.errors);
        },
      });
  }

  logout(): void {
    this.currentUser = null;
    localStorage.removeItem('user');
    this.toastr.success(`Log out successful.`);
    this.router.navigate(['/login']);
  }

  isAuthenticated(): boolean {
    return this.currentUser !== null || localStorage.getItem('user') !== null;
  }

  getUser(): User | null {
    return (
      this.currentUser || JSON.parse(localStorage.getItem('user') as string)
    );
  }

  getToken(): string | null {
    const user = this.getUser();
    return user ? user.token : null;
  }
}
