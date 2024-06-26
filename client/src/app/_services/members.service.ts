import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Member } from 'app/_models/member';
import { environment } from 'environments/environment';

@Injectable({
  providedIn: 'root',
})
export class MembersService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getMembers() {
    return this.http.get<Member[]>(`${this.baseUrl}users`);
  }

  getMember(emailAddress: string) {
    return this.http.get<Member>(`${this.baseUrl}users/${emailAddress}`);
  }
}
