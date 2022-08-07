/* tslint:disable: ordered-imports*/
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

/* Third Party */
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { IconsModule } from '@modules/icons/icons.module';

const thirdParty = [IconsModule, NgbModule];

/* Containers */

/* Components */
import * as appCommonComponents from './components';
import { UserService } from '@shared/services/user.service';


/* Services */

@NgModule({
    imports: [CommonModule, RouterModule, ...thirdParty],
    providers: [UserService,],
    declarations: [...appCommonComponents.components],
    exports: [...appCommonComponents.components, ...thirdParty],
})
export class AppCommonModule {}
