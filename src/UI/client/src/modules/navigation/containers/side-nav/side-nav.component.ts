import { ChangeDetectionStrategy, Component, Input, OnDestroy, OnInit } from '@angular/core';
import { NavigationService } from '@modules/navigation/services';
import { SideNavItems, SideNavSection } from '@shared/models/navigation.model';
import { UserService } from '@shared/services/user.service';
import { Subscription } from 'rxjs';

@Component({
    selector: 'side-nav',

    templateUrl: './side-nav.component.html',
    styleUrls: ['side-nav.component.scss'],
})
export class SideNavComponent implements OnInit, OnDestroy {
    @Input() sidenavStyle!: string;
    @Input() sideNavItems!: SideNavItems;
    @Input() sideNavSections!: SideNavSection[];

    subscription: Subscription = new Subscription();
    routeDataSubscription!: Subscription;

    constructor(public navigationService: NavigationService, public userService: UserService) {}

    ngOnInit() {}

    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
}
