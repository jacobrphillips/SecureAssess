import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Company } from 'app/_models/company';
import { environment } from 'environments/environment';

@Injectable({
  providedIn: 'root',
})
export class CompaniesService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getCompanies() {
    return this.http.get<Company[]>(
      `${this.baseUrl}company`,
      this.getHttpOptions()
    );
  }

  getCompany(name: string) {
    return this.http.get<Company>(
      `${this.baseUrl}company/${name}`,
      this.getHttpOptions()
    );
  }

  getHttpOptions() {
    const userString = localStorage.getItem('user');
    if (!userString) return;
    const user = JSON.parse(userString);
    return {
      headers: new HttpHeaders({
        Authorization: 'Bearer ' + user.token,
      }),
    };
  }
}
