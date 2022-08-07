import { ChangeDetectionStrategy, Component, OnDestroy, OnInit } from '@angular/core';
import { NavigationService } from '@modules/navigation/services';
import { Breadcrumb } from '@shared/models/navigation.model';
import { Subscription } from 'rxjs';

@Component({
    selector: 'breadcrumbs',

    templateUrl: './breadcrumbs.component.html',
    styleUrls: ['breadcrumbs.component.scss'],
})
export class BreadcrumbsComponent implements OnInit, OnDestroy {
    subscription: Subscription = new Subscription();
    breadcrumbs!: Breadcrumb[];

    constructor(public navigationService: NavigationService) {}
    ngOnInit() {
        this.subscription.add(
            this.navigationService.routeData$().subscribe(routeData => {
                this.breadcrumbs = routeData.breadcrumbs;
            })
        );
    }

    ngOnDestroy() {
        this.subscription.unsubscribe();
    }
}
