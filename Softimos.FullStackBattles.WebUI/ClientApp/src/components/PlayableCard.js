import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import Typography from '@material-ui/core/Typography';

const useStyles = makeStyles({
    root: {
        minWidth: 75,
        maxWidth: 250,
        margin: '24px auto',
        textAlign: 'center',
    },
    title: {
        fontSize: 14,
    },
    description: {
        marginBottom: 12,
    },
    won: {
        borderColor: '#a4c639',
        backgroundColor: '#c7dc85',
    },
    lost: {
        borderColor: '#e03c31',
        backgroundColor: '#e86c64',
    },
    draw: {
        borderColor: '#ffbf00',
        backgroundColor: '#ffd24d',
    },
});

export default function PlayableCard({ playerName, resourceName, attributeDisplayName, resourceType, resourceValue, cardStyle }) {
    const classes = useStyles();

    return (
        <Card className={classes.root + ' ' + classes[cardStyle]} variant="outlined">
            <CardContent>
                <Typography className={classes.title} color="textSecondary" gutterBottom>
                    {playerName}
        </Typography>
                <Typography variant="h5" component="h2">
                    {resourceName || '?'}
                </Typography>
                <Typography className={classes.description} color="textSecondary">
                    {resourceType}
        </Typography>
                <Typography variant="body2" component="p">
                    {attributeDisplayName}: <strong>{resourceValue || ''}</strong>
                </Typography>
            </CardContent>
        </Card>
    );
}