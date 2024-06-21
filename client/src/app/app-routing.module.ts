import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { MemberListComponent } from './components/member/member-list/member-list.component';
import { MemberDetailsComponent } from './components/member/member-details/member-details.component';
import { ListsComponent } from './components/lists/lists.component';
import { MessagesComponent } from './components/messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';
import { AuthReverseGuard } from './_guards/auth-reverse.guard';
import { TestErrorComponent } from './errors/test-error/test-error.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { HomeComponent } from './components/home/home.component';
import { CompanyListComponent } from './components/company/company-list/company-list.component';
import { CompanyDetailsComponent } from './components/company/company-details/company-details.component';

const routes: Routes = [
  {
    path: '',
    canActivate: [AuthGuard],
    children: [
      { path: 'home', component: HomeComponent },
      { path: 'members', component: MemberListComponent },
      { path: 'members/:emailaddress', component: MemberDetailsComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'messages', component: MessagesComponent },
      { path: 'companies', component: CompanyListComponent },
      { path: 'companies/:name', component: CompanyDetailsComponent },
    ],
  },
  { path: 'login', component: LoginComponent, canActivate: [AuthReverseGuard] },
  {
    path: 'register',
    component: RegisterComponent,
    canActivate: [AuthReverseGuard],
  },
  { path: 'errors', component: TestErrorComponent },
  { path: 'not-found', component: NotFoundComponent },
  { path: 'server-error', component: ServerErrorComponent },
  { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
