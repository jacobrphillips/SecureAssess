import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  login(model: any): Observable<any> {
    return this.http.post(this.baseUrl + 'account/login', model);
  }

  register(model: any): Observable<any> {
    return this.http.post(this.baseUrl + 'account/register', model);
  }
}
