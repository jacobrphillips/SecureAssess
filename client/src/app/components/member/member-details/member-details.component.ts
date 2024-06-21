import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Member } from 'app/_models/member';
import { MembersService } from 'app/_services/members.service';

@Component({
  selector: 'app-member-details',
  templateUrl: './member-details.component.html',
  styleUrl: './member-details.component.css',
})
export class MemberDetailsComponent implements OnInit {
  member: Member | undefined;

  constructor(
    private memberService: MembersService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadMember();
  }

  loadMember() {
    const emailaddress = this.route.snapshot.paramMap.get('emailaddress');
    if (!emailaddress) return;
    this.memberService.getMember(emailaddress).subscribe({
      next: (member) => (this.member = member),
    });
  }
}
