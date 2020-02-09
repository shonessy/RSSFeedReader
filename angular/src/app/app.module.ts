import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientJsonpModule } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';

import { ModalModule } from 'ngx-bootstrap';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AbpModule } from '@abp/abp.module';

import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';

import { HomeComponent } from '@app/Components/home/home.component';
import { AboutComponent } from '@app/Components/about/about.component';
import { TopBarComponent } from '@app/Components/layout/topbar.component';
import { TopBarLanguageSwitchComponent } from '@app/Components/layout/topbar-languageswitch.component';
import { SideBarUserAreaComponent } from '@app/Components/layout/sidebar-user-area.component';
import { SideBarNavComponent } from '@app/Components/layout/sidebar-nav.component';
import { SideBarFooterComponent } from '@app/Components/layout/sidebar-footer.component';
import { RightSideBarComponent } from '@app/Components/layout/right-sidebar.component';
// tenants
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateTenantDialogComponent } from './tenants/create-tenant/create-tenant-dialog.component';
import { EditTenantDialogComponent } from './tenants/edit-tenant/edit-tenant-dialog.component';
// roles
import { RolesComponent } from '@app/roles/roles.component';
import { CreateRoleDialogComponent } from './roles/create-role/create-role-dialog.component';
import { EditRoleDialogComponent } from './roles/edit-role/edit-role-dialog.component';
// users
import { UsersComponent } from '@app/users/users.component';
import { CreateUserDialogComponent } from '@app/users/create-user/create-user-dialog.component';
import { EditUserDialogComponent } from '@app/users/edit-user/edit-user-dialog.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { ResetPasswordDialogComponent } from './users/reset-password/reset-password.component';
import { RssToJsonService } from './Services/rss-to-json/rss-to-json.service';
import { FeedCardComponent } from './Components/feed-card/feed-card.component';
import { StripHtmlTagsPipe } from './Pipes/strip-html-tags/strip-html-tags.pipe';
import { ServerFeedsComponent } from './Components/server-feed/server-feeds.component';
import { RssServerFeedsService } from './Services/rss-server-feeds/rss-server-feeds.service';
import { ServerFeedDetailsComponent } from './Components/server-feed/server-feed-details/server-feed-details.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    TopBarComponent,
    TopBarLanguageSwitchComponent,
    SideBarUserAreaComponent,
    SideBarNavComponent,
    SideBarFooterComponent,
    RightSideBarComponent,
    // tenants
    TenantsComponent,
    CreateTenantDialogComponent,
    EditTenantDialogComponent,
    // roles
    RolesComponent,
    CreateRoleDialogComponent,
    EditRoleDialogComponent,
    // users
    UsersComponent,
    CreateUserDialogComponent,
    EditUserDialogComponent,
    ChangePasswordComponent,
    ResetPasswordDialogComponent,
    //
    FeedCardComponent,
    StripHtmlTagsPipe,
    ServerFeedsComponent,
    ServerFeedDetailsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    HttpClientJsonpModule,
    ModalModule.forRoot(),
    AbpModule,
    AppRoutingModule,
    ServiceProxyModule,
    SharedModule,
    NgxPaginationModule
  ],
  providers: [
    RssToJsonService,
    RssServerFeedsService
  ],
  entryComponents: [
    // tenants
    CreateTenantDialogComponent,
    EditTenantDialogComponent,
    // roles
    CreateRoleDialogComponent,
    EditRoleDialogComponent,
    // users
    CreateUserDialogComponent,
    EditUserDialogComponent,
    ResetPasswordDialogComponent    
  ]
})
export class AppModule {}
