import { Component } from '@angular/core';
import { AuthService } from 'app/_services/auth.service';
import { User } from 'app/_models/user';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent {
  constructor(public authService: AuthService) {}

  logout(): void {
    this.authService.logout();
  }

  get emailaddress(): string | null {
    const user: User | null = this.authService.getUser();
    return user ? user.emailAddress : null;
  }
}
