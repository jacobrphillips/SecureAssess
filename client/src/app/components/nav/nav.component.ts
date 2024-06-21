import { Component, OnInit } from '@angular/core';
import { AuthService } from 'app/_services/auth.service';
import { User } from 'app/_models/user';
import { Member } from 'app/_models/member';
import { MembersService } from 'app/_services/members.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  user: User | null = null;
  member: Member | undefined;

  constructor(
    public authService: AuthService,
    public memberService: MembersService
  ) {}

  ngOnInit(): void {
    this.getUser();
    this.getPhotoUrl();
  }

  getUser(): void {
    this.user = this.authService.getUser();
  }

  logout(): void {
    this.authService.logout();
  }

  get emailAddress(): string | null {
    return this.user ? this.user.emailAddress : null;
  }

  getPhotoUrl(): void {
    if (this.emailAddress) {
      this.memberService.getMember(this.emailAddress).subscribe({
        next: (member) => {
          this.member = member;
        },
      });
    }
  }
}
