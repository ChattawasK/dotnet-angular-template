/* tslint:disable: ordered-imports*/
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

/* Modules */
import { AppCommonModule } from '@common/app-common.module';
import { NavigationModule } from '@modules/navigation/navigation.module';


/* Containers */
import * as authContainers from './containers';

/* Guards */
import * as authGuards from './guards';
import { UserService } from '@shared/services/user.service';
import { AuthService } from '@shared/services/auth.service';


@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        FormsModule,
        AppCommonModule,
        NavigationModule,
    ],
    providers: [AuthService, UserService, ...authGuards.guards],
    declarations: [...authContainers.containers],
    exports: [...authContainers.containers],
})
export class AuthModule {}
