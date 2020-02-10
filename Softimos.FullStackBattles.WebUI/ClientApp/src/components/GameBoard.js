import React, { useState, useEffect } from 'react';
import PlayableCard from './PlayableCard';
import axios from 'axios';

const API_URL = "https://localhost:44354/api/v1";

function GameBoard(props) {
    const emptyCard = { name: '', value: 0 };
    const [player1Card, setPlayer1Card] = useState(emptyCard);
    const [player2Card, setPlayer2Card] = useState(emptyCard);

    const fetchCardData = async (cardSetter) => {
        try {
            const response = await axios(
                `${API_URL}/${props.selectedResource.resourceName}/random`,
            );

            let cardData = {
                name: response.data.name,
                value: response.data[props.selectedResource.commonAttributeName]
            }

            cardSetter(cardData);
        }
        catch {
            props.setMessageText("Error: Cannot reach resources API endpoint.");
        }
    };

    useEffect(() => {
        if (props.gameStatus === "active") {
            fetchCardData(setPlayer1Card);
            fetchCardData(setPlayer2Card);
        }
    }, [props.gameStatus]);

    const compareResults = () => {
        if (player1Card.value !== 0 && player2Card.value !== 0) {
            if (player1Card.value > player2Card.value) {
                props.setGameStatus("p1");
            } else if (player1Card.value < player2Card.value) {
                props.setGameStatus("p2");
            } else {
                props.setGameStatus("draw");
            }
        }
    }

    compareResults();

    const determinePlayerOutcome = (playerNumber) => {
        if (player1Card.value !== 0 && player2Card.value !== 0) {
            if ((player1Card.value > player2Card.value && playerNumber === 1) ||
                (player2Card.value > player1Card.value && playerNumber === 2)) {
                return 'won';
            } else if (
                (player1Card.value < player2Card.value && playerNumber === 1) ||
                (player2Card.value < player1Card.value && playerNumber === 2)) {
                return 'lost';
            } else {
                return 'draw';
            }
        }
    }

    return (
        <div>
            <PlayableCard
                key={'player1Card' + player1Card.name}
                playerName='Player 1'
                resourceName={player1Card.name}
                attributeDisplayName={props.selectedResource.commonAttributeDisplayName}
                resourceType={props.selectedResource.resourceDisplayName}
                resourceValue={player1Card.value}
                cardStyle={determinePlayerOutcome(1)}
            />
            <PlayableCard
                key={'player2Card' + player2Card.name}
                playerName='Player 2'
                resourceName={player2Card.name}
                attributeDisplayName={props.selectedResource.commonAttributeDisplayName}
                resourceType={props.selectedResource.resourceDisplayName}
                resourceValue={player2Card.value}
                cardStyle={determinePlayerOutcome(2)}
            />
        </div>
    );
}

export default GameBoard;